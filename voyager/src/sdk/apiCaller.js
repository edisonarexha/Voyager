// from node server

import axios from "axios";

const headers = {
  Accept: "application/json",
  "Content-Type": "application/json",
};

const apiCaller = axios.create({
  baseURL: "http://localhost:3000/",
  timeout: 60 * 100,
  headers,
});

export default apiCaller;