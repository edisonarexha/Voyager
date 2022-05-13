<template>
  <div>
    <HeaderView />
    <div class="main__pic">
      <img class="imggg" src="../assets/view.png" />
    </div>

    <div class="contact__form">
      <div class="left__div">
        <b-form class="contact__form-form" @submit.prevent="createContact">
          <h3>Get in touch</h3>
          <div class="form-input__inline mt-5">
            <b-input v-model="form.name" placeholder="Name" class="inputs__form" />
            <b-input v-model="form.email" placeholder="Email" class="inputs__form" />
          </div>
          <b-input v-model="form.subject" placeholder="Subject" style="height: 50px" class="mt-4" />
          <b-textarea v-model="form.message" placeholder="Message" rows="7" no-resize class="mt-4" />
          <b-button type="submit" class="mt-3" style="height: 50px" variant="primary"
            >Send Message</b-button
          >
        </b-form>
      </div>
      <div class="right__div">
        <div class="right__div-infos">
          <h3 class="right__div-title">Contact us</h3>
          <div>
            <div class="address__contact">
              <div class="circle">
                <i style="font-size: 23px" class="el-icon-location-outline"></i>
              </div>
              <p class="text-address__contact">
                <b>Address:</b> 198 West 21th Street, Suite 721 New York NY
                10016
              </p>
            </div>
            <div class="address__contact mt-3">
              <div class="circle">
                <i style="font-size: 23px" class="el-icon-phone"></i>
              </div>
              <p style="align-self: center" class="text-address__contact">
                <b>Phone:</b> +38345123456
              </p>
            </div>

            <div class="address__contact mt-3">
              <div class="circle">
                <i style="font-size: 23px" class="el-icon-s-promotion"></i>
              </div>
              <p style="align-self: center" class="text-address__contact">
                <b>Email:</b> info@hotmail.com
              </p>
            </div>

            <div class="address__contact mt-3">
              <div class="circle">
                <globe-icon size="1.5x" class="custom-class"></globe-icon>
              </div>
              <p style="align-self: center" class="text-address__contact">
                <b>Website:</b> voyager.com
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>

    <!-- SERVICE CHAT -->

    <div class="service__chat">
      <div class="service__chat-content">
        <div class="first__div">
          <p class="first__text">Service Chat</p>
          <p style="font-weight: 600;" class="second__text">
            Get instant help whenever you need it
          </p>
        </div>

        <div class="services">
          <div class="single__service">
            <div class="single__service-icons">
              <img style="width:30px; height:30px;" src="../assets/hotel.png" />
            <p style="margin-left:5px;">Hotels</p>
            </div>
            <i style="font-size: 23px; margin-right:15px;" class="el-icon-arrow-right"></i>
            
          </div>

           <div class="single__service">
            <div class="single__service-icons">
              <img style="width:30px; height:30px;" src="../assets/plane.png" />
            <p style="margin-left:5px;">Flights</p>
            </div>
            <i style="font-size: 23px; margin-right:15px;" class="el-icon-arrow-right"></i>
            
          </div>

           <div class="single__service">
            <div class="single__service-icons">
              <img style="width:30px; height:30px;" src="../assets/train.png" />
            <p style="margin-left:5px;">Trains</p>
            </div>
            <i style="font-size: 23px; margin-right:15px;" class="el-icon-arrow-right"></i>
            
          </div>

           <div class="single__service">
            <div class="single__service-icons">
              <img style="width:30px; height:30px;" src="../assets/car.png" />
            <p style="margin-left:5px;">Car Rentals</p>
            </div>
            <i style="font-size: 23px; margin-right:15px;" class="el-icon-arrow-right"></i>
            
          </div>

          <div class="single__service">
            <div class="single__service-icons">
              <img style="width:30px; height:30px;" src="../assets/airport.png" />
            <p style="margin-left:5px;">Airport Transfers</p>
            </div>
            <i style="font-size: 23px; margin-right:15px;" class="el-icon-arrow-right"></i>
          </div>

          <div class="single__service">
            <div class="single__service-icons">
              <img style="width:30px; height:30px;" src="../assets/tours.png" />
            <p style="margin-left:5px;">Tours & Tickets</p>
            </div>
            <i style="font-size: 23px; margin-right:15px;" class="el-icon-arrow-right"></i>
            
          </div>
        </div>


        <div class="last__div">
          <div class="single__serivce-last">
            <headphones-icon size="1.5x" class="custom-class"></headphones-icon>
            <p style="margin-left: 5px">Chat</p>
          </div>

          <div class="single__serivce-last">
            <phone-icon size="1.5x" class="custom-class"></phone-icon>
            <p style="margin-left: 5px">Call Us</p>
          </div>

          <div class="single__serivce-last">
            <mail-icon size="1.5x" class="custom-class"></mail-icon>
            <p style="margin-left: 5px">Email Us</p>
          </div>

          <div style="border: none" class="single__serivce-last">
            <info-icon size="1.5x" class="custom-class"></info-icon>
            <p style="margin-left: 5px">FAQ</p>
          </div>
        </div>

      
      </div>
      <div class="footer">
  <FooterView/>
  </div>
    </div>

    <!-- SERVICE CHAT -->
  </div>
</template>

<script>
import { GlobeIcon } from "vue-feather-icons";
import { InfoIcon } from "vue-feather-icons";
import { MailIcon } from "vue-feather-icons";
import { PhoneIcon } from "vue-feather-icons";
import { HeadphonesIcon } from 'vue-feather-icons'
import HeaderView from '../views/Header.vue'
import apiRequests from "../utils/apiRequests";
import FooterView from '../views/Footer.vue'

export default {
  components: {
    GlobeIcon,
    InfoIcon,
    MailIcon,
    PhoneIcon,
    HeadphonesIcon,
    HeaderView,
    FooterView
  },
   data() {
    return {
      form: {
        name: "",
        email: "",
        subject: "",
        message: "",
      },
      error: null,
      success: null,
    };
  },

  methods:{
      makeToast() {
      this.$toast.success("Contact has been added succesfully", {
     position: "top-right",
  timeout: 3000,
  closeOnClick: true,
  pauseOnFocusLoss: true,
  pauseOnHover: true,
  draggable: true,
  draggablePercent: 0.6,
  showCloseButtonOnHover: false,
  hideProgressBar: true,
  closeButton: "button",
  icon: true,
  rtl: false
});
    },
    makeFailToast() {
           this.$toast.error("Please fill all the data please", {
     position: "top-right",
  timeout: 3000,
  closeOnClick: true,
  pauseOnFocusLoss: true,
  pauseOnHover: true,
  draggable: true,
  draggablePercent: 0.6,
  showCloseButtonOnHover: false,
  hideProgressBar: true,
  closeButton: "button",
  icon: true,
  rtl: false
});
    },
    clearForm() {
      this.form = {
        name: '',
        email: '',
        subject: '',
        message: ''
      };
    },
     async createContact() {
      if (
        this.form.name == "" ||
        this.form.email == "" ||
        this.form.subject == "" ||
        this.form.message == ""
      ) {
        this.makeFailToast();
      } else {
        await apiRequests.createContact({ ...this.form });
        this.makeToast();
        this.clearForm();
      }
    },
  }
};
</script>

<style scoped>
.single__service-icons{
  display:flex;
   align-items:center;
    margin-left:15px;
}
.single__serivce-last {
  width: 20%;
  height: 40%;
  border-right: 2px solid #f5f7fa;
  text-align: center;
  display: flex;
  justify-content: center;
  cursor:pointer;
  /* border:1px solid black; */
}

.single__serivce-last:hover{
  color:#95b1ea;
}

.single__serivce-last p {
  margin: 0;
  font-weight: 500;
  font-size: 14px;
}

.last__div {
  width: 100%;
  height: 70px;
  /* border:1px solid red; */
  display: flex;
  justify-content: space-evenly;
  align-items: center;
}
/* .break {
  width: 100%;
  height: 12px;
  background-color: #f5f7fa;
} */
.single__service {
  width: 26%;
  height: 70px;
  background-color: #f5f7fa;
  margin-right: 55px;
  display: flex;
  align-items: center;
  justify-content: space-between;
  cursor:pointer;
}

.single__service:hover{
    color:#95b1ea;

}

.single__service p {
  margin: 0;
  font-weight: 500;
  font-size: 14px;
  font-family: 'Open Sans', sans-serif;

}
.services {
  padding-left: 15px;
  margin-top: 15px;
  width: 100%;
  height: 205px;
  /* border:1px solid white; */
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
}
.first__text {
  font-weight: 600;
  font-size: 22px;
  margin: 0;
    font-family: 'Open Sans', sans-serif;

}
.second__text {
  font-size: 14px;
  margin: 0;
  margin-left: 10px;
  align-self: center;
  color: #4fb4d0;
}

.first__div {
  padding: 10px;
  display: flex;
}

.service__chat {
  margin-top: 7%;
  width: 100%;
  height: 540px;
  /* border:1px solid red; */
  /* background-color:#4e8af2 */
}
.service__chat-content {
  /* padding:15px; */
  width: 65%;
  height: 65%;
  /* border-left: 2px solid #f5f7fa; */
  /* border-right: 4px solid #f5f7fa; */
  background-color: white;
  margin: 0 auto;
  margin-top: 5%;
  /* border-radius:15px; */
  /* border:1px solid black; */
}

.main__pic {
  width: 100%;
  height: 400px;
}
.imggg {
  height: 100%;
  width: 100%;
  object-fit: cover;
}

.contact__form {
  margin-top: -3% !important;
  width: 65%;
  height: 550px;
  margin: 0 auto;
  display: flex;
  border-radius: 15px;
}

.left__div {
  width: 60%;
  height: 95%;
  background-color: white;
  /* border: 1px solid green; */
  border-top-left-radius: 10px;
  border-bottom-left-radius: 10px;
}

.right__div {
  width: 40%;
  height: 95%;
  /* border:1px solid green; */
  border-top-right-radius: 10px;
  background-color: #4e8af2;
  border-bottom-right-radius: 10px;
  color: white;
}

.contact__form-form {
  width: 80%;
  height: 90%;
  margin: 0 auto;
  margin-top: 30px;
}

.form-input__inline {
  display: flex;
  justify-content: space-between;
}

.inputs__form {
  width: 47%;
  height: 50px;
}

.inputs__form::placeholder {
  font-size: 18px;
}

.right__div-infos {
  width: 80%;
  height: 90%;
  margin: 0 auto;
  margin-top: 30px;
  /* outline: 1px solid white; */
}

.circle {
  width: 50px;
  height: 50px;
  border-radius: 500px;
  background-color: #5f94f1;
  display: flex;
  justify-content: center;
  align-items: center;
}

.address__contact {
  padding: 10px;
  margin-top: 15px;
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  /* align-items:center; */
}

.text-address__contact {
  margin: 0;
  width: 63%;
  margin-left: 15px;
}

.right__div-title {
  font-weight: 500;
  
}

@media only screen and (max-width: 800px) {
  .contact__form {
    margin-top: -3% !important;
    width: 100%;
    height: fit-content;
    margin: 0 auto;
    display: flex;
    flex-direction: column;
  }
  .left__div {
    margin: 0 auto;
    width: 80%;
    height: fit-content;
    border-radius: 10px;
  }

  .right__div {
    margin: 0 auto;
    margin-top: 5%;
    width: 80%;
    height: fit-content;
    border-radius: 10px;
  }

  .single__service {
  width: 70%;
  height: 70px;
  background-color: #f5f7fa;
  margin-top: 10px;
  display: flex;
  align-items: center;
  justify-content: space-between;
  cursor:pointer;
}
.services{
  height:fit-content;
}
}
.footer{
  border-top: 1px solid #DCDFE6;
  padding-top: 50px;
}
</style>
