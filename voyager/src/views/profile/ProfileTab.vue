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
                    <p class="mt-2 comment__style">Post something</p>
                    </div>
                    <h3>Joell White</h3>
                    </div>

                    <div class="right__details">
                        <img src="../../assets/profilePic3.png" />
                    </div>
            </div>

             <div class="single__review">
                <div class="left__details">
                    <div class="left__details-top">
                        <img width="30" src="../../assets/quotes.png" />
                    <p class="mt-2 comment__style">Post something</p>
                    </div>
                    <h3>Joell White</h3>
                    </div>

                    <div class="right__details">
                        <img src="../../assets/profilePic3.png" />
                    </div>
            </div>


        </div>
    </div>
</div>
</template>


<style scoped>
.main__div{
    width:100%;
    height:fit-content;
    display: flex;
    justify-content: space-evenly;
}

.left__div{
    width:30%;
    height:100%;
    /* border:1px solid red; */
}

.right__div{
    width:60%;
    height:fit-content;
    /* border:1px solid red; */
}

.profile__single-package{
    display:flex;
    margin-top:5%;
}

.image-style{
    width:35%;
    height:50%;
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
    font-family: Open Sans;
}

.single__package-claimed{
    color:#6E798C;
    width:40%;
    text-align: center;
}
.single__review{
    margin-top:5%;
    margin-left:15%;   
    width:80%;
    height:40%;
    /* border:1px solid green; */
    display: flex;
    justify-content: space-between;
}

.left__details{
    height:100%;
    width:50%;
    /* border:1px solid green; */
    display: flex;
    flex-direction: column;
    justify-content: center;
    font-family: Open Sans;
}


.left__details-top{
    width:100%;
    height:50%;
    display:flex;
    flex-direction: column;
/* border:1px solid red; */
}

.right__details{
    width:30%;
    height:80%;
    /* border:1px solid red; */
    display:flex;
    align-self:center;
}

.right__details-img{
    width:50px;
    height:50px;
}
.comment__style{
    color:#6E798C;
}

@media only screen and (max-width: 800px) {
.main__div{
    display: flex;
    flex-direction: column;
    justify-content: space-evenly;
}

.left__div{
    width:90%;
    height:fit-content;
    margin:0 auto;
    /* border:1px solid red; */
}

.right__div{
    width:90%;
}

.single__review{
    margin-top:5%;
    margin-left:15%;   
    width:80%;
    height:fit-content;
    /* border:1px solid green; */
    display: flex;
    justify-content: space-between;
}
}
</style>