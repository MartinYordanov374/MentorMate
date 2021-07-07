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
    console.log(maxWidth, maxHeight)
    if(event.pageX>maxWidth || event.pageX<=290)
    {
        alert('Invalid X')
        event.pageX=0
    }
    else if(event.pageY>maxHeight || event.pageY<=117)
    {
        alert('Invalid Y' )
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
    if(event.target.className=='individualGamePanel')
    {
        alert('ERROR! OVERLAPPING ELEMENTS ARE NOT ALLOWED!')
    }
})
