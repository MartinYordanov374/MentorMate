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
})
document.addEventListener('dragenter', (event)=>{
    if(event.target.className=='dropzone')
    {
        event.target.style='opacity:0.5'
        event.target.style='background-color:gray'
    }
},false)
document.addEventListener('dragleave', (event)=>{
    if(event.target.className=='dropzone')
    {
        event.target.style=''
        event.target.style=''
     }
},false)

document.addEventListener('drop', (event)=>{
    if(event.target.className==='dropzone')
    {
        event.target.appendChild(draggedElement)
        event.target.style=''
        event.target.style=''
    }
})
