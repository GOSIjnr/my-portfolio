window.sidebarScrollLock = {
	_scrollY: null,
	_preventScroll: null,

	disableScroll: function (sidebarSelector) {
		const sidebar = document.querySelector(sidebarSelector);

		this._preventScroll = function (e) {
			if (sidebar && sidebar.contains(e.target)) {
				return; // allow scroll inside sidebar
			}
			e.preventDefault();
		};

		// Capture scroll position only once
		if (this._scrollY === null) {
			this._scrollY = window.pageYOffset || window.scrollY || 0;
		}

		// Fix body position offset by scrollY
		document.body.style.position = 'fixed';
		document.body.style.top = `-${this._scrollY}px`;
		document.body.style.left = '0';
		document.body.style.right = '0';
		document.body.style.width = '100%';
		document.body.dataset.scrollY = this._scrollY;

		document.addEventListener('wheel', this._preventScroll, { passive: false });
		document.addEventListener('touchmove', this._preventScroll, { passive: false });
	},

	enableScroll: function () {
		if (this._scrollY === null) return; // nothing to restore

		// Remove fixed styles
		document.body.style.position = '';
		document.body.style.top = '';
		document.body.style.left = '';
		document.body.style.right = '';
		document.body.style.width = '';
		document.body.removeAttribute('data-scroll-y');

		if (this._preventScroll) {
			document.removeEventListener('wheel', this._preventScroll, { passive: false });
			document.removeEventListener('touchmove', this._preventScroll, { passive: false });
			this._preventScroll = null;
		}

		// Restore scroll position exactly to stored _scrollY
		const scrollY = this._scrollY;
		this._scrollY = null; // reset for next time

		// Timeout to allow browser to reflow
		setTimeout(() => {
			// Temporarily disable smooth scroll via inline style
			document.documentElement.style.scrollBehavior = 'auto';
			document.body.style.scrollBehavior = 'auto';

			window.scrollTo({ top: scrollY, left: 0 });

			// Restore original scroll behavior after scrolling
			setTimeout(() => {
				document.documentElement.style.scrollBehavior = '';
				document.body.style.scrollBehavior = '';
			}, 50);
		}, 10);

	}
};
