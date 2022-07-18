<template>
  <div>
    <HeaderView />
    <div class="main">
      <div class="top-main">
        <div class="top-main-left">
          <div class="top-main-left-text">
            <link rel="preconnect" href="https://fonts.googleapis.com" />
            <link
              rel="preconnect"
              href="https://fonts.gstatic.com"
              crossorigin
            />
            <link
              href="https://fonts.googleapis.com/css2?family=Anek+Latin:wght@200&family=Roboto:wght@100&display=swap"
              rel="stylesheet"
            />
            <p class="top-left__first-paragraph">{{this.aboutData ? this.aboutData.description : null}}</p>
            <p class="top-left__second-paragraph">
             {{this.aboutData ? this.aboutData.descriptionSecond : null}}
            </p>
            <button @click="goToContact()" class="top-left__button">Contact US</button>
          </div>
        </div>
        <div class="top-main-right">
          <img src="@/assets/about3.jpg" />
        </div>
      </div>
    </div>

    <div class="second__main">
      <div class="top__div">
        <h1>Meet The Team</h1>
        <p>
          - Our mission is to power global travel for everyone, everywhere. -
        </p>
      </div>
      <div class="team__div">
        <div v-for="(member,index) in teamMembers.data" :key="index" class="single__member">
          <div class="single__member-pic">
            <img v-if="member.photo" :src="require(`@/assets/teamMembers/${member.photo}`)" />
          </div>
          <div class="single__member-details">
            <p class="member__name">{{member.name ? member.name : null}}</p>
            <p class="member__post">{{member.jobName ? member.jobName : null}}</p>
            <p class="member__description">{{member.jobDescription ? member.jobDescription : null}}</p>
            <div class="member__social"> 
              <a href="#"><img width="30" height="30" src="@/assets/icons/facebook.svg" /></a>
              <a href="#"><img width="30" height="30" src="@/assets/icons/instagram.svg" /></a>
              <a href="#"><img width="30" height="30" src="@/assets/icons/linkedin.svg" /></a>
              <a href="#"><img width="30" height="30" src="@/assets/icons/twitter.svg" /></a>
            </div>

          </div>
        </div>
              
             
              
      </div>
    </div>
    <SoonPackages />
    <FooterView />
  </div>
</template>

<script>
import HeaderView from "../Header.vue";
import FooterView from "../Footer.vue";
import SoonPackages from "./SoonPackages.vue";
import {getAboutList} from '../../sdk/about'
import {
  getAllTeamMembers,
} from "../../sdk/teamMembers";
export default {
  components: {
    HeaderView,
    FooterView,
    SoonPackages,
  },
  data(){
    return{
      teamMembers:[],
      aboutData:{}
    }
  },
  mounted(){
    this.getAbout()
    this.getTeamMembers()
  },
  methods:{
    async getTeamMembers(){
      this.teamMembers = await getAllTeamMembers()
    },
    goToContact(){
      this.$router.push('contact')
    },
   async getAbout(){
      const resp = await getAboutList()
      this.aboutData = resp[0]
    }
  }
};
</script>

<style>
.main {
  margin: 0 auto;
  margin-top: 4%;
  width: 90%;
  height: 600px;
  /* outline: 1px solid green; */
}

.top-main {
  width: 100%;
  height: 500px;
  display: flex;
  justify-content: space-evenly;
  align-items: center;
}
.top-main-right {
  width: 45%;
  height: 90%;
}
.top-main-left {
  width: 45%;
  height: 90%;
  display: flex;
  align-items: center;
}

.top-main-left-text {
  margin-top: 42px;
  display: flex;
  flex-direction: column;
  font-family: "Anek Latin", sans-serif;
}

.top-left__second-paragraph {
  margin: 0;
  margin-top: 15px;
  font-family: "Anek Latin", sans-serif;
  line-height: 35px;
  word-spacing: 2px;
  font-size: 18px;
  font-weight:550;
}

.top-left__first-paragraph {
  margin: 0;
  width: fit-content;
  height: 50px;
  font-size: 60px;
  font-weight: 600;
}

.top-main img {
  object-fit: cover;
  width: 100%;
  height: 100%;
}
.top-left__button {
  width: 150px;
  height: 65px;
  background-image: linear-gradient(
    to right,
    #77a1d3 0%,
    #79cbca 51%,
    #77a1d3 100%
  );
  margin: 10px;
  margin-top: 30px;
  margin-left: unset;
  text-align: center;
  text-transform: uppercase;
  transition: 0.5s;
  background-size: 200% auto;
  color: rgb(255, 255, 255);
  box-shadow: 0 0 20px #eee;
  border: none;
  border-radius: 10px;
  display: block;
  font-size: 19px;
  font-weight:600;
}

.top-left__button:hover {
  background-position: right center; /* change the direction of the change here */
  color: #fff;
  text-decoration: none;
}

.top__div {
  width: 80%;
  height: 150px;
  margin: 0 auto;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}
.top__div p {
  margin: 0;
  margin-top: 25px;
  word-spacing: 1px;
  font-size: 18px;
  line-height: 30px;
  font-weight:600;
}

.top__div h1 {
  color: #4982c5;
  font-weight: 500;
  font-family: "Open Sans";
}

.second__main {
  height: 1000px;
  width: 100%;
  /* outline: 1px solid green; */
}

.team__div {
  width: 90%;
  margin: 0 auto;
  height: 850px;
  /* outline: 1px solid red; */
  display: flex;
  flex-direction: row;
  justify-content: space-evenly;
  flex-wrap: wrap;
}
.single__member {
  margin-top: 35px;
  width: 40%;
  height: 43%;
  /* outline: 1px solid blue; */
  display: flex;
  justify-content: space-between;
  align-items:center;
}
.single__member-pic{
  width:50%;
  height:100%;
  /* outline:1px solid black; */
}
.single__member-pic img{
  object-fit: cover;
  width:100%;
  height:100%;
}
.single__member-details{
  width:45%;
  height:90%;
  display: flex;
  flex-direction: column;
  justify-content: space-evenly;
}
.member__name{
  font-size:29px;
  margin:0;
  font-family: 'Open Sans';
}

.member__post{
   font-size:17px;
  margin:0;
  font-family: 'Open Sans';

  font-weight: 500;
}
.member__description{
    font-size:14px;
  margin:0;
  font-family: 'Open Sans';
  font-weight: 300;
}
.member__social{
  height:15%;
  margin-top:5;
  width:75%;
  display:flex;
  justify-content: space-between;
  align-items:center;
  /* outline:1px solid red; */
}

@media only screen and (max-width: 800px) {

  .main{
    width:100%;
    height:fit-content;
  }

  .top-main{
    width:100%;

    height:fit-content;
    display: flex;
    flex-direction: column;
  }

  .top-left__button{
    margin:0 auto;
  }

  .top-left__first-paragraph{
    margin:0 auto;
  }

  .top-main-left{
    width:100%;
    height:fit-content;
    text-align: center;
  }

.second__main{
  width:100%;
  height:fit-content;
  margin-top:10px;
  margin-bottom:10px;
  display: flex;
  flex-direction: column;
}

.single__member{
  width:100%;
  display:flex;
  flex-direction: column;
}

.team__div{
  height:fit-content;
}

.single__member-details{
  margin-top:15px;
}

.member__post{
  margin-top:15px;
}

.member__description{
  margin-top:15px;
}
.member__social{
  width:100%;
  display:flex;
  justify-content: space-evenly;
  margin-top:15px;
}

}
</style>
