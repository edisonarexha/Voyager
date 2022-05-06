<template>
  <div class="main__div">
    <div class="all__packages">
      <div class="div__single-package">
        <div class="div-package__image">
          <img class="package__image" src="../../assets/view.png" />
        </div>
        <div class="details">
          <div class="div__first-details">
            <p>Travel Packages</p>
            <p>17 days ago</p>
          </div>
          <div class="div__second-details">
            <h4 class="second-details__h3">Family Pack</h4>
            <p class="second-details__p">
              This is the second part of the SMM starter pack series of
              articles. If you made it this far, you must be willing to learn
              about promoting business through social media.
            </p>
          </div>
          <div class="div__last-details">
              <a style="font-weight:600;" href="#">Voyager</a>
              <a style="font-weight:400, Regular" href="#">Claim this &#x2192;</a>
              </div>
        </div>
      </div>

        <div class="div__single-package">
        <div class="div-package__image">
          <img class="package__image" src="../../assets/singlePack.png" />
        </div>
        <div class="details">
          <div class="div__first-details">
            <p>Travel Packages</p>
            <p>17 days ago</p>
          </div>
          <div class="div__second-details">
            <h4 class="second-details__h3">Single Pack</h4>
            <p class="second-details__p">
              This is the second part of the SMM starter pack series of
              articles. If you made it this far, you must be willing to learn
              about promoting business through social media.
            </p>
          </div>
          <div class="div__last-details">
              <a style="font-weight:600;" href="#">Voyager</a>
              <a style="font-weight:400, Regular" href="#">Claim this &#x2192;</a>
              </div>
        </div>
      </div>

        <div class="div__single-package">
        <div class="div-package__image">
          <img class="package__image" src="../../assets/businessPack.png" />
        </div>
        <div class="details">
          <div class="div__first-details">
            <p>Travel Packages</p>
            <p>17 days ago</p>
          </div>
          <div class="div__second-details">
            <h4 class="second-details__h3">Business Pack</h4>
            <p class="second-details__p">
              This is the second part of the SMM starter pack series of
              articles. If you made it this far, you must be willing to learn
              about promoting business through social media.
            </p>
          </div>
          <div class="div__last-details">
              <a style="font-weight:600;" href="#">Voyager</a>
              <a style="font-weight:400, Regular" href="#">Claim this &#x2192;</a>
              </div>
        </div>
      </div>

        <div class="div__single-package">
        <div class="div-package__image">
          <img class="package__image" src="../../assets/honeyMoonPack.png" />
        </div>
        <div class="details">
          <div class="div__first-details">
            <p>Travel Packages</p>
            <p>17 days ago</p>
          </div>
          <div class="div__second-details">
            <h4 class="second-details__h3">HoneyMoon Pack</h4>
            <p class="second-details__p">
              This is the second part of the SMM starter pack series of
              articles. If you made it this far, you must be willing to learn
              about promoting business through social media.
            </p>
          </div>
          <div class="div__last-details">
              <a style="font-weight:600;" href="#">Voyager</a>
              <a style="font-weight:400, Regular" href="#">Claim this &#x2192;</a>
              </div>
        </div>
      </div>

      
    </div>
    <div class="div-button__skip">
      <b-button @click="redirectToHomePage" class="button__skip">Next..</b-button>
    </div>
  </div>
</template>

<script>
export default {
  methods:{
    redirectToHomePage(){
      this.$router.push('/homepage')
    }
  }
}
</script>


<style scoped>
*{
    font-family:sans-serif;
}
html,
body {
  margin: 0;
}
.main__div {
  width: 100%;
  height: 100vh;
  background-color: rgb(236, 236, 236)
}

.all__packages {
  width: 100%;
  height: 85%;
  display: flex;
  flex-direction: row;
  justify-content: space-evenly;
  align-items: center;
  /* border: 1px solid red; */
}

.div__single-package {
  border-radius: 15px;
  width: 21%;
  height: 67%;
  background-color: white;
}
.package__image {
  height: 100%;
  width: 100%;
  object-fit: cover;
  border-top-left-radius: 15px;
  border-top-right-radius: 15px;
}
.div-button__skip {
  width: 95%;
  display: flex;
  justify-content: flex-end;
}
.button__skip {
  background: #6e41e2;
  border: none;
  width: 80px;
}

.button__skip:hover {
  background: #4e17da;
}
.div-package__image {
  width: 100%;
  height: 45%;
}

.div__first-details {
  margin-top: 6px;
  width: 100%;
  height: 15%;
  display: flex;
  justify-content: space-between;
}

.div__first-details p {
    margin-top:7px;
  color: #6e798c;
  font-style: normal;
  font-size: 13px;
  line-height: 15px;
}

.details {
  width: 90%;
  height: 55%;
  margin: 0 auto;
}

.div__second-details {
  width: 100%;
  height: 65%;
  outline: red;
}

.second-details__h3 {
  color:#081F32;
  font-size:20px;
  font-weight: 600;
}

.second-details__p{
    margin-top:15px;
color:#374A59;
font-size:14px;
}

.div__last-details{
    margin:0 auto;
    width:80%;
    height:13%;
    display:flex;
    justify-content: space-between;
}

.div__last-details a{
    text-decoration: none;
    font-size:13px;
}

@media only screen and (max-width: 800px) {
.all__packages{
    display:flex;
    flex-direction:column;
    width:fit-content;
    height:fit-content;
}
.div__single-package{
    width:fit-content;
    height:fit-content;
    margin-top:10px;
}
}
</style>
