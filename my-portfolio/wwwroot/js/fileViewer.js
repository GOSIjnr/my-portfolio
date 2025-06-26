/**
 * Opens a given URL in a new browser tab with security flags.
 * @param {string} url - The URL to open.
 */

function openFileInNewTab(url) {
	if (typeof url !== 'string' || url.trim() === '') {
		console.error('openFileInNewTab: Invalid URL');
		return;
	}

	window.open(url, '_blank', 'noopener,noreferrer');
}
