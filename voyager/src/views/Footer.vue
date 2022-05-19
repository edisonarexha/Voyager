<template>
  <div class="flexed footer">
    <div class="logo">
      <img  src="../assets/voyager.png" >
    </div>
    <div class="flexed-column">
      <h5>Overview</h5>
      <span class="pointer">Family Pack</span>
      <span class="pointer">Business Pack</span>
      <span class="pointer">Single Pack</span>
      <span class="pointer">Honeymoon Pack</span>
      
    </div>
    <div class="flexed-column">
      <h5>About Us</h5>
      <span class="pointer" @click="goToAboutUs()">About Us</span>
    </div>
    <div class="flexed-column">
      <h5>Contact Us</h5>
      <span class="pointer" @click="goToContact()"><navigation-icon size="1.5x" class="custom-class"></navigation-icon> Contact Us</span>
      <span class="pointer"><phone-call-icon size="1.5x" class="custom-class"></phone-call-icon> +38349249988</span>
      <span class="pointer"><mail-icon size="1.5x" class="custom-class"></mail-icon> ceo@voyager.com</span>
    </div>
    <div class="m-r-100 flexed-column">
      <h5>Social Media</h5>
      <span class="pointer"><facebook-icon size="1.5x" class="custom-class"></facebook-icon> Facebook</span>
      <span class="pointer"><instagram-icon size="1.5x" class="custom-class"></instagram-icon> Instagram</span>
      <span class="pointer"><twitter-icon size="1.5x" class="custom-class"></twitter-icon> Twitter</span>
      <span class="pointer"><linkedin-icon size="1.5x" class="custom-class"></linkedin-icon> Linkedin</span>
    </div>
  </div>
</template>

<script>
import { FacebookIcon, InstagramIcon, TwitterIcon, LinkedinIcon, PhoneCallIcon, NavigationIcon, MailIcon } from 'vue-feather-icons'
export default {
  name: 'FooterView',
   components: {
    FacebookIcon, InstagramIcon, TwitterIcon, LinkedinIcon, PhoneCallIcon, NavigationIcon, MailIcon
  },
  methods:{
     goToAboutUs() {
      this.$router.push({
        name: "about-us",
      })},
      goToContact() {
      this.$router.push({
        name: "contact",
      });
    },
  }

}
</script>

<style scoped>
.flexed{
  display: flex;
  justify-content: space-between;
  
}
.footer{
  border-top: 1px solid #DCDFE6;
  padding-top: 50px;
}
.logo{
   align-self: center;
   margin: 10px;
}
.m-r-100{
  margin-right: 100px;
}
.flexed-column{
display: flex;
flex-direction: column;
}
.flexed-column span{
  margin-bottom: 10px;
}
.pointer{
  cursor: pointer;
}
.flexed-column span:hover{
  color:#007AE9;
}
</style>