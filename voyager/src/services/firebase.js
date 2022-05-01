import { initializeApp } from "firebase/app";
import { getAuth, onAuthStateChanged } from "firebase/auth";
import store from "../store";
const firebaseConfig = {
    apiKey: "AIzaSyAqXiMeLMdW6ZKfGA-LLs6XaycDlTv7hnw",
    authDomain: "voyager-f1f0c.firebaseapp.com",
    projectId: "voyager-f1f0c",
    storageBucket: "voyager-f1f0c.appspot.com",
    messagingSenderId: "88581908409",
    appId: "1:88581908409:web:9caf1b9af4a4f0ea26b868"
  };

initializeApp(firebaseConfig);

onAuthStateChanged(getAuth(), (user) => {
  store.dispatch("fetchUser", user);
});