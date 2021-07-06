const addNewGameButton = document.getElementById('newGame')

let panelCounter = 0
addNewGameButton.addEventListener('click',(event)=>
{
    let newElem = document.createElement('DIV')
    newElem.className='individualGamePanel'
    newElem.id=`${panelCounter}`
    newElem.draggable=true
    document.getElementById('gamesPanelContainer').appendChild(newElem)
    panelCounter+=1

})
