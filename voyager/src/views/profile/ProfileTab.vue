<template> 
<div>
    <div class="main__div">
        <div class="left__div">
            <h5 class="single__package-claimed mt-5">Claimed:</h5>
        <div class="profile__single-package">
            <div class="image-style"> 
                <img class="image" src="../../assets/HomeRoom.jpg" />    
            </div>
            <div class="packages__details">
                <p>Package</p>
                <h3>Family Pack</h3>

            </div>
        </div>

 <div class="profile__single-package">
            <div class="image-style"> 
                <img class="image" src="../../assets/HomePageMainPicture.jpg" />    
            </div>
            <div class="packages__details">
                <p>Package</p>
                <h3>Family Pack</h3>

            </div>
        </div>


        </div>


        <div class="right__div">
            <div class="single__review">
                <div class="left__details">
                    <div class="left__details-top">
                        <img width="30" src="../../assets/quotes.png" />
                    <p>Post something</p>
                    </div>
                    <h3>Leon Shala</h3>
                    </div>
            </div>
            <div class="single__review"> <p> Single comment </p></div>
        </div>
    </div>
</div>
</template>


<style scoped>
.main__div{
    width:100%;
    height:500px;
    /* border:1px solid red; */
    display: flex;
    justify-content: space-evenly;
}

.left__div{
    width:30%;
    height:100%;
    border:1px solid red;
}

.right__div{
    width:60%;
    height:500px;
    border:1px solid red;
}

.profile__single-package{
    display:flex;
    margin-top:5%;
}

.image-style{
    width:35%;
    height:40%;
    border-top-left-radius: 15px;
    border-bottom-left-radius:15px;
    overflow: hidden;
}

.packages__details{
    width:50%;
    margin-left:5%;
    height:50%;
    display: flex;
    flex-direction: column;
    align-self: center;
}

.single__package-claimed{
    color:#6E798C;
    width:40%;
    text-align: center;
}
.single__review{
    width:80%;
    height:40%;
    border:1px solid green;
    display: flex;
}

.left__details{
    height:100%;
    width:50%;
    border:1px solid green;
    display: flex;
    flex-direction: column;
    justify-content: center;
}


.left__details-top{
    width:100%;
    height:50%;
    display:flex;
    flex-direction: column;
    border:1px solid red;

}
</style>