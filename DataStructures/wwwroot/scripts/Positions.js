window.getScreenSize = () => {
    return {
        width: document.body.clientWidth,
        height: document.body.clientHeight
    }
}

window.getBoundingClientRect = (element) => {
    const rect = element.getBoundingClientRect();
    return {
        top: rect.top,
        left: rect.left,
        width: rect.width,
        height: rect.height
    }
}