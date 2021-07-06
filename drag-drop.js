let draggedElement = ''
document.addEventListener("drag",(event) => {
});
document.addEventListener('dragstart', (event)=>{
    draggedElement = event.target

})
document.addEventListener('dragend', (event)=>{
})
document.addEventListener('dragover', (event)=>{

    event.preventDefault()
    if(event.pageX>maxWidth)
    {
        console.log('Invalid X')
        event.pageX=0
    }
    else if(event.pageY>maxHeight)
    {
        console.log('Invalid Y')
        event.pageY=0
    }
    console.log(event.pageX, event.pageY)
})
document.addEventListener('dragenter', (event)=>{
    console.log(event.target.className)
    if(event.target.className=='gamesPanelContainer')
    {

    }
},false)
document.addEventListener('dragleave', (event)=>{
    if(event.target.className=='gamesPanelContainer')
    {

     }
},false)

document.addEventListener('drop', (event)=>{
    
})
