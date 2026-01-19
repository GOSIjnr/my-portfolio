window.fileAndTab = {
	downloadFile: function (url, filename = '') {
		if (typeof url !== 'string' || !url) {
			console.error('downloadFile: Invalid URL');
			return;
		}

		const link = document.createElement('a');
		link.href = url;
		link.download = filename;
		link.target = '_blank';
		link.rel = 'noopener noreferrer';

		document.body.appendChild(link);
		link.click();
		document.body.removeChild(link);
	},

	openFileInNewTab: function (url) {
		if (typeof url !== 'string' || url.trim() === '') {
			console.error('openFileInNewTab: Invalid URL');
			return;
		}

		window.open(url, '_blank', 'noopener,noreferrer');
	}
};
