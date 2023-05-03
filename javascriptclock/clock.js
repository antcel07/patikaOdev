var kisi=document.getElementById("myName");
var clock=document.getElementById("myClock");

var hosgeldin=prompt("Hoş Geldin Dostum adını yazar mısın?","Kerem");

kisi.innerHTML+= hosgeldin

var gunler=["","Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi","Pazar"]

   
function tarihfonk(){
    var gun = new Date();
    clock.innerText=gunler[gun.getDay()];
    var tarih=new Date().toLocaleString('tr-TR');
    clock.innerText+=" "+tarih;

}

setInterval(tarihfonk,1000)