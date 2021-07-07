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
    let x = event.pageX
    let y = event.pageY
    console.log(x,y)
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
    // console.log(`X: ${event.pageX}, Y:${event.pageY}`)
})
document.addEventListener('dragenter', (event)=>{
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
