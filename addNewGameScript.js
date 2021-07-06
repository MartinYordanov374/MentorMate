const addNewGameButton = document.getElementById('newGame')

let panelCounter = 0
let dropZoneContainer = document.getElementById('dropZoneContainer')
addNewGameButton.addEventListener('click',(event)=>
{   
    if(panelCounter>=4)
    {
        alert('ERROR! YOU CANNOT ADD MORE THAN THE CURRENT GAME PANELS')
    }
    else
    {
        
        if(panelCounter==0)
        {
            let newElem = document.createElement('DIV')
            newElem.className='individualGamePanel'
            newElem.id=`${panelCounter}`
            newElem.innerText=`${panelCounter}`
            
            newElem.draggable=true
            document.getElementById('dropZoneContainer').appendChild(newElem)
        }
        else
        {
            let newElem = document.createElement('DIV')
            newElem.className='individualGamePanel'
            newElem.id=`${panelCounter}`
            newElem.innerText=`${panelCounter}`
            newElem.draggable=true
            document.getElementById('gamesPanelContainer').appendChild(newElem)
        }    
    }
    panelCounter+=1

})