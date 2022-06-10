import request from './request'

export function getHotels(){
    return request.get('/Hotel').then(response => {
        return response
    }).catch((err) => console.log(err.name))
}