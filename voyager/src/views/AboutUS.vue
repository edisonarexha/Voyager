<template>
  <div>
    <HeaderView />
    <img class="contact-img" src="../assets/view.png" />
    <div class="top-left">
      Book now for the best prices <br />
      yet
    </div>
    <div class="centered-header">Voyager For you About us</div>
    <div>
      <img class="second-img" src="../assets/room.png" />
    </div>
    <div class="paragraph">
      <p>
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
        tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim
        veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea
        commodo consequat. "Lorem ipsum dolor sit amet, consectetur adipiscing
        elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi
        ut aliquip ex ea commodo consequat. "Lorem ipsum dolor sit amet,
        consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore
        et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud
        exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
        "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
        tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim
        veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea
        commodo consequat. "Lorem ipsum dolor sit amet, consectetur adipiscing
        elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
        Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi
        ut aliquip ex ea commodo consequat.
      </p>
    </div>
  </div>
</template>

<script>
  import HeaderView from '../views/Header.vue'

export default {
  components:{
    HeaderView
  }
};
</script>

<style>
.top-left {
  position: absolute;
  width: 324px;
  height: 69px;
  left: 100px;
  top: 170px;
  font-family: "Inter";
  font-style: normal;
  font-weight: 600;
  font-size: 23px;
  line-height: 34px;

  text-align: right;

  color: #ffffff;
}
.contact-img {
  width: 100%;
  height: 500px;
}
.second-img {
  width: 100%;
  height: 500px;
}
.centered-header {
  width: 100%;
  height: 200px;
  padding: 60px;
  font-family: "DM Serif Display";
  font-style: normal;
  font-weight: 400;
  font-size: 40px;
  line-height: 46px;
  color: #081f32;
}
.paragraph{
  margin: 50px;
}
</style>
