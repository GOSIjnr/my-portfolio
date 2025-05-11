window.downloadFile = function (url) {
	const link = document.createElement('a');
	link.href = url;
	link.download = '';
	link.target = '_blank';
	document.body.appendChild(link);
	link.click();
	document.body.removeChild(link);
};

window.openFileInNewTab = function (url) {
	window.open(url, '_blank');
};
