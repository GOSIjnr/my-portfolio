window.resizeNotifier = (function () {
	let _dotNetResizeCallbackHelper = null;

	function _handleWindowResizeEvent() {
		const currentWindowWidth = window.innerWidth;

		if (_dotNetResizeCallbackHelper) {
			_dotNetResizeCallbackHelper.invokeMethodAsync("OnResize", currentWindowWidth);
		}
	}

	return {
		registerResizeCallback: function (dotNetResizeCallbackHelper) {
			_dotNetResizeCallbackHelper = dotNetResizeCallbackHelper;
			window.addEventListener("resize", _handleWindowResizeEvent);
		}
	};
})();
