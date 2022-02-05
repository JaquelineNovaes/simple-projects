
function interruptor(sta)
{      
    
   if (sta == 1)
   {
		document.getElementById('myImage').src ='imagens/pcroxo.jpg';
   }
   
   if (sta==2)
   {
		document.getElementById('myImage').src ='imagens/pcrosa.jpg';
   }
}


function identifica()

{

    var nome = document.getElementById('nome').value;
    
    alert("Seja Bem-vindo(a) " +nome+ " !");        

}

 
    
    var oper = 0;
	var memoria = 0;

	function escrever(digito) 
	{
		var visor = document.getElementById('visor');
		visor.value = visor.value + digito;
	}
	function operacao(op) 
	{
		var visor = document.getElementById('visor');
		oper = op;
		memoria = parseInt(visor.value);
		visor.value = "";
	}
	function calcula() 
	{
		var visor = document.getElementById('visor');
		var resultado = 0;
		
		if(oper==1) resultado = memoria + parseInt(visor.value);
		if(oper==2) resultado = memoria - parseInt(visor.value);
		if(oper==3) resultado = memoria * parseInt(visor.value);
		if(oper==4) resultado = memoria / parseInt(visor.value);
		
		visor.value = resultado;
	}
	
	function limpa()
	{
		document.getElementById('visor').value="";
		oper = 0;
		memoria = 0;		
	}
           


