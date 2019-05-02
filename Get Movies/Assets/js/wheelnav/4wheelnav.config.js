var elementId = "piemenu";
var elem = document.getElementById(elementId);
var slicesNum = elem.childElementCount;
var navAngles = [225,240,247.5,252,255,257.14285714285717,258.75];
//elem.setAttribute("data-wheelnav-titleheight",60-((slicesNum-2)*5));
//elem.setAttribute("data-wheelnav-titleheight",slicesNum ==2? 180/slicesNum : 60);

var piemenu = new wheelnav(elementId);
piemenu.spreaderInTitle = icon.plus;
piemenu.spreaderOutTitle = icon.cross;
piemenu.spreaderRadius = piemenu.wheelRadius * 0.34;
piemenu.clockwise = true;
piemenu.sliceInitPathFunction = piemenu.slicePathFunction;
piemenu.initPercent = 0.1;
piemenu.wheelRadius = piemenu.wheelRadius * 0.83;
piemenu.navItemsContinuous = true;
piemenu.sliceAngle = 360/slicesNum;
piemenu.createWheel();
var toolTips = ['Search A Movie','','My Playlists','Dashboard'];
var discriminatingIcon = "M166.47274353192026,109.074375L162.69474353192027,102.532375C161.55574353192026,100.56037500000001,159.69274353192026,97.332375,158.55374353192028,95.360375L154.77574353192028,88.818375C153.6357435319203,86.845375,151.7727435319203,86.845375,150.6337435319203,88.818375L146.8567435319203,95.360375C145.7177435319203,97.332375,143.85374353192032,100.561375,142.7147435319203,102.532375L138.93774353192032,109.074375C137.7987435319203,111.04837500000001,138.73074353192033,112.661375,141.00874353192032,112.661375H164.3997435319203C166.6797435319203,112.661375,167.61074353192032,111.04837500000001,166.47274353192032,109.074375ZM153.78374353192027,110.08737500000001H151.54274353192025V107.93637500000001H153.78374353192027V110.08737500000001ZM153.67574353192026,106.351375H151.65274353192027L151.45174353192027,97.14737500000001H153.85874353192028L153.6757435319203,106.35137500000002Z";

window.addEventListener("DOMContentLoaded", function() 
{
    setTimeout(function()
    {
        var arr = toolTips.slice(0,slicesNum-1);
        arr[arr.length]="Logout";
        if(document.querySelectorAll('path[d="'+discriminatingIcon+'"]').length==0 ) {arr[1] = "Your Profile" ;}else{arr[1] = "Click To Login !";}
        
        piemenu.setTooltips(arr)
    },2000);
}, false);

//logged of ['Search A Movie','']
//banned    ['Search A Movie','']

//casual    ['Search A Movie','',logout]

//prem      ['Search A Movie','',playlist,logout]

//adm       ['Search A Movie','',playlist,dash,logout]
