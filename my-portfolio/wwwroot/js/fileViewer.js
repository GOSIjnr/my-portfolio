window.openFileInNewTab = function (url) {
	if (typeof url !== 'string' || !url) {
		console.error('openFileInNewTab: Invalid URL');
		return;
	}

	window.open(url, '_blank', 'noopener,noreferrer');
};
