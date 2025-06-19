window.imageLoader = {
	/**
	 * Applies a CSS background image with fallback.
	 * @param {Object} options
	 * @param {string} options.elementId
	 * @param {string} options.cssProperty
	 * @param {string} options.imageUrl
	 * @param {string} options.fallbackUrl
	 * @param {boolean} [options.useVariable=true]
	 */
	applyCssImageWithFallback: function ({ elementId, cssProperty, imageUrl, fallbackUrl, useVariable = true }) {
		const img = new Image();
		img.onload = () => {
			const target = document.getElementById(elementId);
			if (!target) return;
			if (useVariable) {
				target.style.setProperty(cssProperty, `url('${imageUrl}')`);
			} else {
				target.style[cssProperty] = `url('${imageUrl}')`;
			}
		};
		img.onerror = () => {
			const target = document.getElementById(elementId);
			if (!target) return;
			if (useVariable) {
				target.style.setProperty(cssProperty, `url('${fallbackUrl}')`);
			} else {
				target.style[cssProperty] = `url('${fallbackUrl}')`;
			}
		};
		img.src = imageUrl;
	},

	/**
	 * Sets the `src` of an <img> element with fallback.
	 * @param {Object} options
	 * @param {string} options.elementId
	 * @param {string} options.imageUrl
	 * @param {string} options.fallbackUrl
	 */
	applyImgSrcWithFallback: function ({ elementId, imageUrl, fallbackUrl }) {
		const imgElement = document.getElementById(elementId);
		if (!imgElement) return;

		const testImg = new Image();
		testImg.onload = () => {
			imgElement.src = imageUrl;
		};
		testImg.onerror = () => {
			imgElement.src = fallbackUrl;
		};
		testImg.src = imageUrl;
	}
};
