<!DOCTYPE html>
<html>
<head>
<script>
	function countries(){
	var x1=document.getElementById('text 1').value;
	var x2=document.getElementById('text 2').value;
	var x3=document.getElementById('text 3').value;
	var x4=document.getElementById('text 4').value;
	var x5=document.getElementById('text 5').value;
	var x6=document.getElementById('text 6').value;
	var x7=document.getElementById('text 7').value;
	var x8=document.getElementById('text 8').value;
	var x9=document.getElementById('text 9').value;
	var x10=document.getElementById('text 10').value;

	alert ("country name 1: "+x1+"\n country name 2: "+x2+"\n country name 3: "+x3+"\n country name 4:"+x4+"\n country name 5:"+x5+"\n country name 6:"+x6 );
	}
	var countries=[country name 1: "+x1+"\n country name 2: "+x2+"\n country name 3: "+x3+"\n country name 4:"+x4+"\n country name 5:"+x5+"\n country name 6:"+x6 ];
	countries.sort();
	
	</script>
<title>Famous Destinations</title>
<link rel="stylesheet" href="css/style.css">
 <style>
    a { color: #1CC714;
		text-decoration: none; } /* CSS link color */
  </style>

</head>
<body>
	<div class="super_container">
		<header class="header">
		<div class="container">                        
			<div class="row">
				<div class="col">
					<div class="header_content d-flex flex-row align-items-center justify-content-start">
						<div class="header_content_inner d-flex flex-row align-items-end justify-content-start">
							<nav class="main_nav">
				 			 	<ul class="d-flex flex-row align-items-start justify-content-start">
									<li><a href="index.html">Shingarjeet Singh</a></li>
									<li><a href="index.html">Harman Singh</a></li>
									<li><a href="index.html">Bableen Kaur</a></li>
									<li><a href="index.html">Manjot Kaur</a></li>
			    				</ul>
							</nav>
					  	</div>
					</div>
				</div>
			</div>
		</div>
		</header>
		<div class="backgroundMain">
			<div class="logo"><a href="index.html">Famous Destinations</a>
					<form class="form">
						<label> Enter 10 countries you like or you have visited in the past</label>
							<br><br><br>
						<label>country name 1: <input type="text" name="country name 1" id="text 1"><br><br>
						<label>country name 2: <input type="text" name="country name 2" id="text 2"><br><br>
						<label>country name 3: <input type="text" name="country name 3" id="text 3"><br><br>
						<label>country name 4: <input type="text" name="country name 4" id="text 4"><br><br>
						<label>country name 5: <input type="text" name="country name 5" id="text 5"><br><br>
						<label>country name 6: <input type="text" name="country name 6" id="text 6"><br><br>
						<label>country name 7: <input type="text" name="country name 7" id="text 7"><br><br>
						<label>country name 8: <input type="text" name="country name 8" id="text 8"><br><br>
						<label>country name 9: <input type="text" name="country name 9" id="text 9"><br><br>
						<label>country name10: <input type="text" name="country name 10" id="text10"><br><br>
						<button id="submit" value="display" onclick="countries()">Display</button>
						<button type="button">Enter</button>
					</form>
			</div>
			<div>
				<a href="https://www.ucityguides.com/cities/top-10-most-beautiful-countries-in-the-world.html">
					<img src="http://transparency.org.au/tia/wp-content/uploads/2016/10/australia-sydney.jpg" width="350px" height="250px"/>
				 		<br><label style="margin: 0px 130px;">Australia</label>
				</a>
			</div>
			<div>
				<a href= "https://www.visitdubai.com/en/discover/things-to-do-in-dubai">
					<img src="https://img.grouponcdn.com/deal/gA4f2jvdsE1BeG7WUNku7ehjF21/gA-1115x669/v1/c700x420.jpg" width="350px" height="250px"/>
				 		<br><label style="margin: 0px 140px;">Dubai</label>
				 </a>
			</div>
			<form style="float:left;" >
		</div>
	</div>
</body>					
</html>
