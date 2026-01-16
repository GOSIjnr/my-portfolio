window.resizeNotifier = (function () {
	let _dotNetResizeCallbackHelper = null;
	let _resizeHandler = null;

	function _handleWindowResizeEvent() {
		const currentWindowWidth = window.innerWidth;
		if (_dotNetResizeCallbackHelper) {
			_dotNetResizeCallbackHelper.invokeMethodAsync("OnResize", currentWindowWidth);
		}
	}

	return {
		registerResizeCallback: function (dotNetHelper) {
			_dotNetResizeCallbackHelper = dotNetHelper;

			if (!_resizeHandler) {
				_resizeHandler = _handleWindowResizeEvent;
				window.addEventListener("resize", _resizeHandler);
			}
		},

		unregisterResizeCallback: function () {
			if (_resizeHandler) {
				window.removeEventListener("resize", _resizeHandler);
				_resizeHandler = null;
			}

			_dotNetResizeCallbackHelper = null;
		}
	};
})();
