let elementContainer = document.querySelector('#adminPanelContainer')
document.addEventListener('mousedown',()=>{
    if (elementContainer.offsetHeight < elementContainer.scrollHeight ||
    elementContainer.offsetWidth < elementContainer.scrollWidth)
    {
        elementContainer.style.height=elementContainer.clientHeight+300
        maxHeight=elementContainer.clientHeight+300
    }
    else
    {
        console.log('no overflow detected')
    }
})