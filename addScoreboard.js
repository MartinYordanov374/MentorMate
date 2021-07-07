const addScoreboardButton = document.getElementById('scoreboard')
let scoreBoardCounter = 0
let scoreboards=[]
let panels = 0
addScoreboardButton.addEventListener('click',(event)=>{
    if(panels.length>=1)
    {
        // you cannot add a second scoreboard in this case
        if(scoreBoardCounter>=1)
        {
            alert('ERROR! YOU CANNOT CREATE MORE THAN THE CURRENT SCOREBOARDS!')
        }
        else
        {

            let scoreboard = document.createElement('DIV')
            scoreboard.className='scoreboardPanel'
            scoreboard.id=`${scoreBoardCounter}`
            document.getElementById('scoreboardContainer').appendChild(scoreboard)
        }
    }
    else
    {
        // you can add a second scoreboard in this case
        if(scoreBoardCounter>=2)
        {
            alert('ERROR! YOU CANNOT CREATE MORE THAN THE CURRENT SCOREBOARDS!')
        }
        else
        {
            let scoreboard = document.createElement('DIV')
            scoreboard.className='scoreboardPanel'
            scoreboard.id=`${scoreBoardCounter}`
            document.getElementById('scoreboardContainer').appendChild(scoreboard)
        }
    }
    scoreboards.push(1)
    
    scoreBoardCounter+=1

})