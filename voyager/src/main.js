import Vue from "vue";
import App from "./App.vue";
import router from "./router";
import '@/plugins/element.js'
import store from "./store";
import BootstrapVue from 'bootstrap-vue'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import "./services/firebase";
import Toast from "vue-toastification";
import "vue-toastification/dist/index.css";
import VueMaterial from 'vue-material'
import 'vue-material/dist/vue-material.css'
const options = {
  // You can set your default options here
};


Vue.use(Toast, options);
Vue.use(BootstrapVue)
Vue.config.productionTip = false;
Vue.use(VueMaterial)


new Vue({
  router,
  store,
  render: (h) => h(App),
}).$mount("#app");
