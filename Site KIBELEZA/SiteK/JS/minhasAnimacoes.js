$('.banner').slick({
	slidesToShow: 1,
	slidesToScroll: 1,
	autoplay: true,
	autoplaySpeed: 2000,
	dots: true
});

new WOW().init();

/* Menu Mobile */
document.querySelector(".abrir-menu").onclick = function(){

	document.documentElement.classList.add("menu-ativo");

}
document.querySelector(".fechar-menu").onclick = function(){

	document.documentElement.classList.remove("menu-ativo");

}
/* Fim do Menu Mobile */

$(function(){   
	var nav = $('.menufa');   
	$(window).scroll(function () { 
		if ($(this).scrollTop() > 150) { 
			nav.addClass("menuf");
			$('body').css('padding-top', 70);
		} else { 
			nav.removeClass("menuf"); 
			$('body').css('padding-top', 0);
		} 
	});  
});


var url = "https://www.instagram.com/explore/tags/beleza/?__a=1";
var bloco = document.getElementById('insta');
var insta;
var http = new XMLHttpRequest();

http.open("GET", url);
http.responseType = "json";
http.addEventListener("readystatechange", function(){

	if(http.readyState == 4){
		if(http.status == 200){
			insta = http.response.graphql.hashtag.edge_hashtag_to_media.edges;
			for(let i = 0; i < insta.length; i++){
				console.log(insta[i].node.thumbnail_resources[4].src);

				bloco.innerHTML += `<div class="item">
				<img src="${insta[i].node.thumbnail_resources[4].src}" alt="${insta[i].node.edge_media_to_caption.edges[0].node.text}">
									</div>`;
			}
		}
	}
});

http.send();