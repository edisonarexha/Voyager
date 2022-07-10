<template>
  <div>
    <HeaderView />
    <div class="main__div">
      <div class="main__pic">
        <img class="top__image" src="../assets/HomeRoom.jpg" />
      </div>

      <div class="details"> 
        
        <div class="left__div">

        <h2 class="left__div__h2">Prince Hotel VIP Line Booking</h2>
        <p class="left__div__p">  Lorem Ipsum is simply dummy text of the printing and typesetting industry. 
      Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 
      1960s with the release of Letraset sheets containing Lorem Ipsum passages, 
      and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
       Lorem Ipsum is simply dummy text of the printing and typesetting industry.  </p> 
           <b-button class="left__div__button">Claim this</b-button>
          </div>


           <div class="right__div">

        <h2 class="right__div__h2">$20-$450</h2>

        <div class="boxi"> 

          <div class="boxi__top"> 
            <div class="boxi__top__left">
              <h4 class="boxi__top__left-h4">CHECK-IN</h4>
              <el-date-picker
              v-model="checkIn"
                class="datePickerEl"
                :picker-options="datePickerOptions"
                  type="date"
                  placeholder="Pick a day">
              </el-date-picker> 
            </div>

             <div style="border:none;" class="boxi__top__left">
              <h4 class="boxi__top__left-h4">CHECKOUT</h4>
              <el-date-picker
              v-model="checkOut"
                class="datePickerEl"
                  type="date"
                  :picker-options="datePickerOptions"
                  placeholder="Pick a day">
              </el-date-picker> 
            </div>



          </div>
            <div class="boxi__bottom-div">
              <h4 class="boxi__top__left-h4">For</h4>
              <el-dropdown>
  <span class="el-dropdown-link">
    2 Guests<i class="el-icon-arrow-down el-icon--right"></i>
  </span>
  <el-dropdown-menu slot="dropdown">
    <el-dropdown-item>1 Guests</el-dropdown-item>
    <el-dropdown-item>3 Guests</el-dropdown-item>
    <el-dropdown-item disabled>4 Guests</el-dropdown-item>
  </el-dropdown-menu>
</el-dropdown>
              
               </div>


          </div>


          </div>
        

      </div>

    </div>

    <FooterView class="mt-3"/>
  </div>
</template>

<script>
import HeaderView from "./Header.vue";
import FooterView from "./Footer.vue";
export default {
  components: {
    HeaderView,
    FooterView,
  },
  data(){
    return{
      checkIn:'',
      checkOut:'',
       datePickerOptions: {
      disabledDate (date) {
        return date < new Date()
      }
    },
    }
  }
};
</script>

<style scoped>
.el-dropdown-link {
    cursor: pointer;
    color: #6b7280;
  }
  .el-icon-arrow-down {
    /* margin-left:290px; */
    font-size: 14px;
  }
.boxi__bottom-div{
  width:100%;
  height:70px;
  padding:8px;
}
.datePickerEl{
  width:80%;
  border:none !important;
}
.boxi__top__left{
  width:50%;
  height:100%;
  padding:8px;
  border-right:1px solid #d1d5db;
}
.boxi__top__left-h4{
  font-size:17px;
}
.boxi__top{
  width:100%;
  height:91px;
  border-bottom:1px solid #d1d5db;
  display: flex;
  }
.boxi{
  margin:0 auto;
  margin-top:10%;
  width:90%;
  height:165px;
  border:1px solid #d1d5db;
  border-radius:15px;
}
.main__div {
  width: 100%;
  height: fit-content;
}
.main__pic {
  width: 100%;
  height: 600px;
}
.top__image {
  height: 100%;
  width: 100%;
  object-fit: cover;
}

.details{
  margin:0 auto;
  margin-top:5%;
  width:75%;
  height:fit-content;
  display:flex;
  justify-content: space-between;
}

.left__div{
  width:42%;
  height:fit-content;
  display:flex;
  flex-direction: column;
}

.right__div{
  width:40%;
  height:500px;
}

.left__div__p{
  width:95%;
margin-top:30px;
color:#374A59;
/* font-family: 'Open Sans'; */
font-style: normal;
font-weight: 400;
font-size: 14px;
margin-left:10px;
}

.left__div__button{
  background-color:#6E41E2;
  width:25%;
  height:10%;
  margin-top:30%;
}

.left__div__h2{
  width:fit-content;
  font-size:40px;
  font-family: 'DM Serif Display';
}

.right__div__h2{
  font-size:40px;
  font-family: 'DM Serif Display';
  text-align:center;
}


@media only screen and (max-width: 800px) {
.details{
  display:flex;
  flex-direction: column;
}

.left__div{
  width:100%;
  height:fit-content;
}

.right__div{
  width:100%;
  height:fit-content;
}

.boxi{
  width:100%;
}


}

</style>
