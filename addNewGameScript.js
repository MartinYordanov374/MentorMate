const addNewGameButton = document.getElementById('newGame')

addNewGameButton.addEventListener('click',(event)=>
{
    //create div element here
    let newElem = document.createElement('DIV')
    newElem.className='individualGamePanel'
    document.getElementById('gamesPanelContainer').appendChild(newElem)
})