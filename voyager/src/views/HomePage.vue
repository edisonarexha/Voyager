<template>
  <div>
    <HeaderView />
  <div class="row" style="">
      <div class="col-md-12 width">
     <div class="col-md-6 title" >
        <h4> Book now for the best prices<br><span id="yetId"> yet</span></h4>
      </div>
     
      </div>
    
  </div>
  <div class="row stickytop" style="background-color:white">
      <div class="col-md-12">
  <div class="row " style="margin-left:16%;margin-right:10%;height:94px;margin-top:20px;">
      <div class="row"> 
                <div class="col-md-6">
<el-col :span="5">   
    <el-dropdown trigger="click">
      <span class="el-dropdown-link">
      <i class="el-icon-s-promotion"/>  Round Trip<i class="el-icon-arrow-down el-icon--right"></i>
      </span>
      <el-dropdown-menu slot="dropdown">
        <el-dropdown-item icon="el-icon-plus">Germany</el-dropdown-item>
        <el-dropdown-item icon="el-icon-plus">Poland</el-dropdown-item>
        <el-dropdown-item icon="el-icon-plus">Italy</el-dropdown-item>
        <el-dropdown-item icon="el-icon-plus">Sweden</el-dropdown-item>
        <el-dropdown-item icon="el-icon-plus">Spain</el-dropdown-item>
      </el-dropdown-menu>
    </el-dropdown>
  </el-col> 
  <el-col :span="4">   
    <el-dropdown trigger="click">
      <span class="el-dropdown-link">
      <i class="el-icon-user-solid"/>  Adult<i class="el-icon-arrow-down el-icon--right"></i>
      </span>
      <el-dropdown-menu slot="dropdown">
        <el-dropdown-item icon="el-icon-plus">1 Adult</el-dropdown-item>
        <el-dropdown-item icon="el-icon-plus">2 Adults</el-dropdown-item>
      
      </el-dropdown-menu>
    </el-dropdown>
  </el-col> 
  <el-col :span="5">   
    <el-dropdown trigger="click">
      <span class="el-dropdown-link">
      <i class="el-icon-user-solid"/>  Economy<i class="el-icon-arrow-down el-icon--right"></i>
      </span>
      <el-dropdown-menu slot="dropdown">
        <el-dropdown-item icon="el-icon-plus">First Class</el-dropdown-item>
        <el-dropdown-item icon="el-icon-plus">Economy Budget</el-dropdown-item>
      
      </el-dropdown-menu>
    </el-dropdown>
  </el-col> 
  </div>
<div class="col-md-6"  >
     <span id="Maps">Explore Maps <i class="el-icon-discover"></i>
      </span><span id="links"> Looking for Travel Ideas?</span> 
       </div>
   
     <div class="row" style="margin-left:0%;width:100%">
         <div class="col-md-6">
             <div class="row">
                  <div class="col-md-6">
                      <!-- <input class="tinput" placeholder="City or Airplane" type="text"/> -->
<el-input placeholder="City or Airplane" style="height: 42px;
    width: 110%;
    margin-left: -14px;"></el-input>



                 </div>
                 <div class="col-md-6" >
                   <b-button variant="primary-outline" class="t-button" style="color:#007AE9"> <i class="el-icon-discover"/> Anywhere</b-button>
                 </div>
             </div>
         </div>
      <div class="col-md-6" >
           <div class="row"><div class="col-md-11">
                <el-date-picker
                v-model="value2"
                type="daterange"
                align="right"
                unlink-panels
                range-separator="To"
                start-placeholder="Start date"
                end-placeholder="End date"
                :picker-options="pickerOptions"
                style="width: 482px;
                margin-left:-14px;
                height: 44px;"
                >
    </el-date-picker>
               </div> 
           <div class="col-md-1" style="border:1px solid #007AE9;background-color:#007AE9;color:white;    margin-left: -35px;">
               <i class="el-icon-search" style="margin-top: 12px;
    margin-left: 2px;"> </i>
           </div>
                </div>
            
         </div>
         </div>
    
         </div>
       
  </div>  
     
  </div>
  </div>
  <div style="width:100px;height:100px">
  </div>
  <div class="row maincontent">
   <div class="col-md-12 content">
       <div class="row" style="width:100%;height:100%">
       <div class="col-md-4 picture" style="overflow:hidden;border-top-left-radius: 20%;border-bottom-left-radius: 20%;">
            <img src="../assets/HomeRoom.jpg"  class="imageSrc">
       </div>
        <div class="col-md-8" >
        <div class="row"  style="width:104%;height:10%" >
            <div class="col-md-6" >
               <span id="styleL">LONDON</span>
            </div>
             <div class="col-md-6" >
           <span id="date">3 days ago</span>      
            </div>
        </div>
        <div class="row" style="width:104%;height:25%">
            <h3 id="title">   Prince Hotel VIP Line Booking</h3>
         
        </div>
         <div class="row" style="width:104%;height: 56%; overflow:hidden    " >
             <p id="contetText">
                 "Lorem ipsum dolor sit amet, consectetur adipiscing elit,
            sed do eiusmod tempor incididunt ut labore et dolore magna
             aliqua. Ut enim ad minim veniam, quis nostrud exercitation 
             ullamco laboris nisi ut aliquip ex ea commodo consequat. "
             Ut enim ad minim veniam, quis nostrud exercitation 
             ullamco laboris nisi ut aliquip ex ea commodo consequat. "
             Ut enim ad minim veniam, quis nostrud exercitation 
             ullamco laboris nisi ut aliquip ex ea commodo consequat. "
             Ut enim ad minim veniam, quis nostrud exercitation 
             ullamco laboris nisi ut aliquip ex ea commodo consequat. "
             </p>
           
        </div>
        <div class="row"  style="width:104%;height:10%" >
            <div class="col-md-6" >
             <span id="hotel">  Hotel Prince</span>  
            </div>
             <div class="col-md-6" >
              <a href="../details" id="linku"><span class="book">Book Now <i class="el-icon-right"></i></span> </a>    
                  </div>
        </div>
       </div>
       </div>
      </div>
  </div>
  <FooterView/>
  </div>
</template>

<script>
import { mapGetters } from 'vuex';
  import HeaderView from '../views/Header.vue'
  import FooterView from '../views/Footer.vue'

export default {
  components:{
    HeaderView,
    FooterView
  },
     data() {
      return {
        pickerOptions: {
          shortcuts: [{
            text: 'Last week',
            onClick(picker) {
              const end = new Date();
              const start = new Date();
              start.setTime(start.getTime() - 3600 * 1000 * 24 * 7);
              picker.$emit('pick', [start, end]);
            }
          }, {
            text: 'Last month',
            onClick(picker) {
              const end = new Date();
              const start = new Date();
              start.setTime(start.getTime() - 3600 * 1000 * 24 * 30);
              picker.$emit('pick', [start, end]);
            }
          }, {
            text: 'Last 3 months',
            onClick(picker) {
              const end = new Date();
              const start = new Date();
              start.setTime(start.getTime() - 3600 * 1000 * 24 * 90);
              picker.$emit('pick', [start, end]);
            }
          }]
        },
        value1: '',
        value2: ''
      };
    },
    computed: {
    ...mapGetters({
      user: "user",
    }),
  },
}
</script>

<style scoped>
@import url('https://fonts.googleapis.com/css2?family=Open+Sans&display=swap');
@import url('https://fonts.googleapis.com/css2?family=DM+Serif+Display&display=swap');





.stickytop{
    position: sticky;
      top: 0;

}











.tinput{
width: 110%;
    height: 40px;
    margin-left: -12px;
    border: white;
}
::placeholder{
    margin-left:20px;
}
.tinput:focus{
    border-color: #007AE9;
}
.t-button{
        width: 105%;
    margin-left: -12px;
    height: 104%;
}
t-button:hover{
    border-color:#007AE9
}
#links{
    float: right;
      color: #6E798C;
      font-family: 'Open Sans', sans-serif;
      font-size: 14px;
}
#Maps{
    font-size: 14px;
    margin-left: 5px;
     float: right;
       color:#007AE9;
       font-family: 'Open Sans', sans-serif;
}
a:hover{
    text-decoration: underline #007AE9;
}
.book{
     color:#007AE9;
    font-family: 'Open Sans', sans-serif;
    font-weight: 400;
    float:right;
}
#hotel{
    color:#007AE9;
    font-family: 'Open Sans', sans-serif;
    font-weight: 600;
    padding-left: 11px;
}
#title{
font-family: 'DM Serif Display', serif;
padding-top: 30px;
padding-left: 20px;
}
#contetText{
   font-family: 'Open Sans', sans-serif;
    color: #6E798C;
    font-size: 15px;
    padding-left: 19px;
    padding-right: 51px;
}
#styleL{
    font-family: 'Open Sans', sans-serif;
    color:#6E798C;
    font-weight: 600;
    padding-left: 5px;
    padding-top: 5px;
}
#date{
     font-family: 'Open Sans', sans-serif;
    color:#6E798C;
    font-weight: 400; 
    font-size: 15px;
    float: right;
}

.imageSrc{
        width: 123%;
    height: 109%;
    margin-left: -38px;
    margin-top: -31px;

}

.maincontent{
    /* border:1px solid black; */
    height:600px;
    width:70%;
    margin-left: 15%;
      
}
.content{
    /* border:1px solid black; */
        width:100%;
        height: 400px;
        border-radius:20%
        
}

::placeholder {
  color: gray;
   font-family: 'Open Sans', sans-serif;
}

#yetId{
    margin-left:32%;
    
}
.title{
    margin-top:18%;
    margin-left:10%;
    color:white;
    font-family: 'Open Sans', sans-serif;

}
body{overflow-x:hidden;}

/* .img{
    width:110%;
    height: 800px;
    
} */
.width{
    height: 650px;
    overflow: hidden;
    overflow-x: hidden;
    background: linear-gradient(rgba(0, 0, 0, 0.4), rgba(0, 0, 0, 0.4)), url('../assets/HomePageMainPicture.jpg');
    background-position: 70%;
    background-size: 100% 900px;
    
}
.divmod{
    height: 100px;
    overflow-x: hidden;
}
.el-carousel__item h3 {
    color: #475669;
    font-size: 18px;
    opacity: 0.75;
    line-height: 300px;
    margin: 0;
  }

  .el-carousel__item:nth-child(2n) {
    background-color: #99a9bf;
  }

  .el-carousel__item:nth-child(2n+1) {
    background-color: #d3dce6;
  }

</style>