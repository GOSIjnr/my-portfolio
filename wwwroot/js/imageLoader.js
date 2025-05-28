window.imageLoader = {
	applyMaskWithFallback: function (elementId, cssProperty, imageUrl, fallbackUrl, useVariable = false) {
		const img = new Image();
		img.onload = function () {
			const target = document.getElementById(elementId);
			if (target) {
				if (useVariable) {
					target.style.setProperty(cssProperty, `url('${imageUrl}')`);
				} else {
					target.style[cssProperty] = `url('${imageUrl}')`;
				}
			}
		};
		img.onerror = function () {
			const target = document.getElementById(elementId);
			if (target) {
				if (useVariable) {
					target.style.setProperty(cssProperty, `url('${fallbackUrl}')`);
				} else {
					target.style[cssProperty] = `url('${fallbackUrl}')`;
				}
			}
		};
		img.src = imageUrl;
	}
};
