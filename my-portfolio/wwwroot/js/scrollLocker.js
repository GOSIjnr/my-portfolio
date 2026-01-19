window.scrollLocker = (function () {
	const CLASS_NAME = "scroll-locked";
	let lockCount = 0;

	function getScrollbarWidth() {
		return window.innerWidth - document.documentElement.clientWidth;
	}

	return {
		disableScroll: function () {
			lockCount++;

			if (lockCount === 1) {
				document.body.classList.add(CLASS_NAME);
				document.body.style.setProperty("--scrollbar-width", `${getScrollbarWidth()}px`);
			}
		},
		enableScroll: function () {
			lockCount = Math.max(0, lockCount - 1);

			if (lockCount === 0) {
				document.body.classList.remove(CLASS_NAME);
				document.body.style.removeProperty("--scrollbar-width");
			}
		},
		forceUnlock: function () {
			lockCount = 0;
			document.body.classList.remove(CLASS_NAME);
			document.body.style.removeProperty("--scrollbar-width");
		}
	};
})();
