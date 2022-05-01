const getAuthToken = (req,res, next) => {
    if(
        req.headers.authorization
        && req.headers.authorization.split(' ')[0] === 'Bearer'
    )
    {
        req.authToken = req.headers.authorization.split(' ')[1]
    }else{
        req.authToken = null;
    }
    next();
}

export default getAuthToken;