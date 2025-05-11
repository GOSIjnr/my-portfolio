window.downloadFile = function (url, filename = '') {
	if (typeof url !== 'string' || !url) {
		console.error('downloadFile: Invalid URL');
		return;
	}

	const link = document.createElement('a');
	link.href = url;
	link.download = filename;
	link.target = '_blank';
	link.rel = 'noopener noreferrer';

	// Append, trigger click, and remove for cleanup
	document.body.appendChild(link);
	link.click();
	document.body.removeChild(link);
};
