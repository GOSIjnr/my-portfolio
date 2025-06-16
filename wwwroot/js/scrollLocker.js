window.scrollLocker = (function () {
	let _scrollY = null;
	let _preventScroll = null;
	let _targetElement = null;
	const _listenerOptions = { passive: false };

	function preventScroll(e) {
		if (_targetElement && _targetElement.contains(e.target)) {
			return; // Allow scroll inside target element
		}
		e.preventDefault();
	}

	return {
		disableScroll: function (selector) {
			if (_scrollY !== null) return; // already locked

			_targetElement = document.getElementById(selector);

			_scrollY = window.pageYOffset || window.scrollY || 0;

			document.body.style.position = 'fixed';
			document.body.style.top = `-${_scrollY}px`;
			document.body.style.left = '0';
			document.body.style.right = '0';
			document.body.style.width = '100%';

			_preventScroll = preventScroll;

			document.addEventListener('wheel', _preventScroll, _listenerOptions);
			document.addEventListener('touchmove', _preventScroll, _listenerOptions);
		},

		enableScroll: function () {
			if (_scrollY === null) return; // nothing to restore

			document.body.style.position = '';
			document.body.style.top = '';
			document.body.style.left = '';
			document.body.style.right = '';
			document.body.style.width = '';

			document.removeEventListener('wheel', _preventScroll, _listenerOptions);
			document.removeEventListener('touchmove', _preventScroll, _listenerOptions);

			const scrollY = _scrollY;
			_scrollY = null;
			_targetElement = null;
			_preventScroll = null;

			setTimeout(() => {
				document.documentElement.style.scrollBehavior = 'auto';
				document.body.style.scrollBehavior = 'auto';

				window.scrollTo({ top: scrollY, left: 0 });

				setTimeout(() => {
					document.documentElement.style.scrollBehavior = '';
					document.body.style.scrollBehavior = '';
				}, 50);
			}, 10);
		}
	};
})();
