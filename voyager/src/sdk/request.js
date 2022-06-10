import axios from 'axios'

const baseURL = 'https://localhost:44377/api/'

const config = {
  baseURL,
  timeout: 5000,
  headers: {
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Headers': '*',
  },
}

const request = axios.create(config)

export default request