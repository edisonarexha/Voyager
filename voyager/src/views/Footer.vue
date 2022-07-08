<template>
  <div class="">
    <footer class="footer-bs">
      <div class="row">
        <div class="col-md-3 footer-brand animated fadeInLeft">
                <img @click="goToHome" style="cursor:pointer" width="250" src="../assets/logoWhite.png" >
          <p class="mt-3">
            Suspendisse hendrerit tellus laoreet luctus pharetra. Aliquam
            porttitor vitae orci nec ultricies. Curabitur vehicula, libero eget
            faucibus faucibus, purus erat eleifend enim, porta pellentesque ex
            mi ut sem.
          </p>
          <p>© 2022 Voyager, All rights reserved</p>
        </div>
        <div class="col-md-4 footer-nav animated fadeInUp" style="display:flex">
          <div class="col-md-6">
          <h4>Menu —</h4>
            <ul class="pages">
              <li><a href="/homepage">Travel</a></li>
              <li><a href="/packages">Packages</a></li>
              <li><a href="/homepage">Hotels</a></li>
              <li><a href="/homepage">Tickets</a></li>
              <li><a href="/homepage">Advice</a></li>
            </ul>
          </div>
          <div class="col-md-6">
            <ul class="list">
              <li><a href="/about-us">About Us</a></li>
              <li><a href="/contact">Contacts</a></li>
              <li><a href="/about-us">Terms & Condition</a></li>
              <li><a href="/about-us">Privacy Policy</a></li>
            </ul>
          </div>
        </div>
        <div class="col-md-2 footer-social animated fadeInDown">
          <h4>Follow Us</h4>
          <ul>
            <li><a href="#">Facebook</a></li>
            <li><a href="#">Twitter</a></li>
            <li><a href="#">Instagram</a></li>
            <li><a href="#">Linkedin</a></li>
          </ul>
        </div>
        <div class="col-md-3 footer-ns animated fadeInRight">
          <h4>Voyager</h4>
          <p>Our mission is to power global travel for everyone, everywhere.</p>
          <div class="input-group">
           <div class="container">
  <input type="text" placeholder="Search...">
  <div class="search"></div>
</div>
           
          </div>
         
        </div>
      </div>
    </footer>
  </div>
</template>

<script>
export default {
  name: "FooterView",

  methods: {
    goToAboutUs() {
      this.$router.push({
        name: "about-us",
      });
    },
    goToHome() {
      this.$router.push({
        name: "homepage",
      });
    },
    goToContact() {
      this.$router.push({
        name: "contact",
      });
    },
    gotoPackages(){
      this.$router.push({
        name: "packages"
      })
    }
  },
};
</script>

<style>
.footer-bs {
  background-color: #3c3d41;
  padding: 60px 40px;
  color: rgba(255, 255, 255, 1);
  border-bottom-right-radius: 6px;
  border-top-left-radius: 0px;
  border-bottom-left-radius: 6px;
}
.footer-bs .footer-brand,
.footer-bs .footer-nav,
.footer-bs .footer-social,
.footer-bs .footer-ns {
  padding: 10px 25px;
}
.footer-bs .footer-nav,
.footer-bs .footer-social,
.footer-bs .footer-ns {
  border-color: transparent;
}
.footer-bs .footer-brand h2 {
  margin: 0px 0px 10px;
}
.footer-bs .footer-brand p {
  font-size: 12px;
  color: rgba(255, 255, 255, 0.7);
}

.footer-bs .footer-nav ul.pages {
  list-style: none;
  padding: 0px;
}
.footer-bs .footer-nav ul.pages li {
  padding: 5px 0px;
}
.footer-bs .footer-nav ul.pages a {
  color: rgba(255, 255, 255, 1);
  font-weight: bold;
  text-transform: uppercase;
}
.footer-bs .footer-nav ul.pages a:hover {
  color: rgba(255, 255, 255, 0.8);
  text-decoration: none;
}
.footer-bs .footer-nav h4 {
  font-size: 11px;
  text-transform: uppercase;
  letter-spacing: 3px;
  margin-bottom: 10px;
}

.footer-bs .footer-nav ul.list {
  list-style: none;
  padding: 0px;
}
.footer-bs .footer-nav ul.list li {
  padding: 5px 0px;
}
.footer-bs .footer-nav ul.list a {
  color: rgba(255, 255, 255, 0.8);
}
.footer-bs .footer-nav ul.list a:hover {
  color: rgba(255, 255, 255, 0.6);
  text-decoration: none;
}

.footer-bs .footer-social ul {
  list-style: none;
  padding: 0px;
}
.footer-bs .footer-social h4 {
  font-size: 11px;
  text-transform: uppercase;
  letter-spacing: 3px;
}
.footer-bs .footer-social li {
  padding: 5px 4px;
}
.footer-bs .footer-social a {
  color: rgba(255, 255, 255, 1);
}
.footer-bs .footer-social a:hover {
  color: rgba(255, 255, 255, 0.8);
  text-decoration: none;
}

.footer-bs .footer-ns h4 {
  font-size: 11px;
  text-transform: uppercase;
  letter-spacing: 3px;
  margin-bottom: 10px;
}
.footer-bs .footer-ns p {
  font-size: 12px;
  color: rgba(255, 255, 255, 0.7);
}

@media (min-width: 768px) {
  .footer-bs .footer-nav,
  .footer-bs .footer-social,
  .footer-bs .footer-ns {
    border-left: solid 1px rgba(255, 255, 255, 0.1);
  }
}

</style>

<style lang="scss" scoped>
@import url('https://fonts.googleapis.com/css?family=Inconsolata:700');

*{
  font-family:'Open Sans';
}

.container {
  position: absolute;
  margin: auto;
  top: 150px;
  left: 0;
  right: 0;
  bottom: 0;
  width: 300px;
  height: 100px;
  .search {
    position: absolute;
    margin: auto;
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    width: 80px;
    height: 80px;
    background: crimson;
    border-radius: 50%;
    transition: all 1s;
    z-index: 4;
    box-shadow: 0 0 25px 0 rgba(0, 0, 0, 0.4);
    // box-shadow: 0 0 25px 0 crimson;
    &:hover {
      cursor: pointer;
    }
    &::before {
      content: "";
      position: absolute;
      margin: auto;
      top: 22px;
      right: 0;
      bottom: 0;
      left: 22px;
      width: 12px;
      height: 2px;
      background: white;
      transform: rotate(45deg);
      transition: all .5s;
    }
    &::after {
      content: "";
      position: absolute;
      margin: auto;
      top: -5px;
      right: 0;
      bottom: 0;
      left: -5px;
      width: 25px;
      height: 25px;
      border-radius: 50%;
      border: 2px solid white;
      transition: all .5s;
    }
  }
  input {
    font-family: 'Inconsolata', monospace;
    position: absolute;
    margin: auto;
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    width: 50px;
    height: 50px;
    outline: none;
    border: none;
    // border-bottom: 1px solid rgba(255, 255, 255, 0.2);
    background: crimson;
    color: white;
    text-shadow: 0 0 10px crimson;
    padding: 0 80px 0 20px;
    border-radius: 30px;
    box-shadow: 0 0 25px 0 crimson,
                0 20px 25px 0 rgba(0, 0, 0, 0.2);
    // box-shadow: inset 0 0 25px 0 rgba(0, 0, 0, 0.5);
    transition: all 1s;
    opacity: 0;
    z-index: 5;
    font-weight: bolder;
    letter-spacing: 0.1em;
    &:hover {
      cursor: pointer;
    }
    &:focus {
      width: 300px;
      opacity: 1;
      cursor: text;
    }
    &:focus ~ .search {
      right: -250px;
      background: #151515;
      z-index: 6;
      &::before {
        top: 0;
        left: 0;
        width: 25px;
      }
      &::after {
        top: 0;
        left: 0;
        width: 25px;
        height: 2px;
        border: none;
        background: white;
        border-radius: 0%;
        transform: rotate(-45deg);
      }
    }
    &::placeholder {
      color: white;
      opacity: 0.5;
      font-weight: bolder;
    }
  }
}
</style>