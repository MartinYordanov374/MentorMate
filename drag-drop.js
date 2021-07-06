let draggedElement = ''
document.addEventListener("drag",(event) => {
});
document.addEventListener('dragstart', (event)=>{
    console.log('dragging started')
    draggedElement = event.target
})
document.addEventListener('dragend', (event)=>{
    console.log('dragging ended')

})


document.addEventListener('dragover', (event)=>{
    console.log('dragging over')

    event.preventDefault()
})
document.addEventListener('dragenter', (event)=>{
    console.log('dragging entered')

    if(event.target.className=='dropzone')
    {
        event.target.style='opacity:0.5'
        event.target.style='background-color:gray'
    }
},false)
document.addEventListener('dragleave', (event)=>{
    console.log('dragging left')

    if(event.target.className=='dropzone')
    {
        event.target.style=''
        event.target.style=''
     }
},false)

document.addEventListener('drop', (event)=>{
    console.log('dragging dropped')

    if(event.target.className==='dropzone')
    {
        event.target.appendChild(draggedElement)
        event.target.style=''
        event.target.style=''
    }
})
