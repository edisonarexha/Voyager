<template>
  <div>
    <Header></Header>
     <div class="row imagesize" >
    <img src="../assets/HomeRoom.jpg" class="image">
     </div>
     <div class="row sticky-top sticky-lg-top" style="background-color:white">
    <div class="row" >
  <div class="col-md-9" >
  <h3 id="title">   Prince Hotel VIP Line Booking</h3>
  </div>
   <div class="col-md-3" >
    <h3 id="title1">   $5204</h3>
  </div>
    </div>
    <div class="row">
        <div class="col-md-1" style="margin-left: 167px;height:100px" >
          <h6 id="country">Utah</h6>  
        </div>
         <div class="col-md-5" >
           <h6 id="datas">15 days ago </h6>
        </div>
    </div>
     </div>
     <div class="row" style="height:100px;">
    <div class="row">
    <div class="col-md-8" > 
    <div class="row">
       <p class="goldenText">
      Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
      Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 
      1960s with the release of Letraset sheets containing Lorem Ipsum passages, 
      and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
       Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
      Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 
      1960s with the release of Letraset sheets containing Lorem Ipsum passages, 
      and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum. 
       Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
      Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 
      1960s with the release of Letraset sheets containing Lorem Ipsum passages, 
      and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.   
      </p>
    </div>
    <div class="col-md-12">
      <div class="lista">
        <ul>
          <li>Lorem ipsum</li>
           <li>Lorem ipsum</li>
            <li>Lorem ipsum</li>
             <li>Lorem ipsum</li>
          </ul>

      </div>
    </div>
  
    </div>
     <div class="col-md-4" > 
   
    </div>
    </div>
     </div>
  </div>
</template>

<script>
import Header from "./Header.vue";
export default {
    components: { Header }
}
</script>

<style scope>
@import url('https://fonts.googleapis.com/css2?family=Open+Sans&display=swap');
@import url('https://fonts.googleapis.com/css2?family=DM+Serif+Display&display=swap');

.goldenText{
  justify-content:center;
  padding:15px 18%;

}
.lista{
  justify-content:center;
  padding:15px 18%;

}
#country{
 font-family: 'Open Sans', sans-serif;
font-weight:600 ;
color:#6E798C;
padding-left:30px
}
#datas{
 font-family: 'Open Sans', sans-serif;
font-weight:400 ;
color:#6E798C;

}

#title{
font-family: 'DM Serif Display', serif;
padding-top: 10px;
padding-left: 199px;
}
#title1{
font-family: 'DM Serif Display', serif;
padding-top: 10px;
padding-left: 30px;
}
.imagesize{
  overflow: hidden;
  height: 580px;
}
.image{
  width:100%;
  position:relative;
  top: -76%;
}

</style>