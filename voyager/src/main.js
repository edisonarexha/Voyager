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
import VueApexCharts from 'vue-apexcharts'
import Chat from 'vue-beautiful-chat'
/* import the fontawesome core */
import { library } from '@fortawesome/fontawesome-svg-core'

/* import font awesome icon component */
import { FontAwesomeIcon } from '@fortawesome/vue-fontawesome'

/* import specific icons */
import { faUserSecret } from '@fortawesome/free-solid-svg-icons'
const options = {
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
  rtl: false,
};
library.add(faUserSecret)
Vue.component('font-awesome-icon', FontAwesomeIcon)
Vue.use(Toast, options);
Vue.use(BootstrapVue)
Vue.config.productionTip = false;
Vue.use(VueMaterial)
Vue.use(VueApexCharts)
Vue.component('apex-chart', VueApexCharts)
Vue.use(Chat)

new Vue({
  router,
  store,
  render: (h) => h(App),
}).$mount("#app");
