window.resizeNotifier = {
	registerResizeCallback: function (dotnetHelper) {
		window.addEventListener("resize", () => {
			const width = window.innerWidth;
			dotnetHelper.invokeMethodAsync("OnResize", width);
		});
	}
};
