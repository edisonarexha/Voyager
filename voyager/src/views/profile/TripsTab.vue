<template> 
<div>
    <div class="main__div"> 
        <div class="single__trip">
            <div class="image__trip">
                <img class="image__details" src="../../assets/tripsTabFirstPic.png" />
            </div>

            <h4 class="title__trip">American First Sahara Hotel</h4>
            <div class="top__details">
                <div class="left__top__details">
                    <p>SEP 25-30</p>
                    <p>1 ROOM</p>
                </div>
                <div class="right__top__details">
                    <h3 class="price__top__details mt-2">$250<small style="font-size:18px; font-weight:600">/night</small></h3>
                </div>

            </div>
                <div class="bottom__details mt-1">
                    <p class="details__p">"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod
                         tempor incididunt ut labore et dolore magna aliqua. 
                         Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut 
                         aliquip ex ea commodo consequat. </p>
                </div>

                <div class="bottom__button mt-4"> <p>Booked</p></div>
        </div>





         <div class="single__trip">
            <div class="image__trip">
                <img class="image__details" src="../../assets/room.png" />
            </div>

            <h4 class="title__trip">Prince Hotel VIP Line</h4>
            <div class="top__details">
                <div class="left__top__details">
                    <p>SEP 25-30</p>
                    <p>1 ROOM</p>
                </div>
                <div class="right__top__details">
                    <h3 class="price__top__details mt-2">$250<small style="font-size:18px; font-weight:600">/night</small></h3>
                </div>

            </div>
                <div class="bottom__details mt-1">
                    <p class="details__p">Located on the sparkling waterfront of Tanjung Benoa Beach, the Holiday Inn Resort Bali Benoa offers beachfront activities, an exciting Kids Club,
                         four pools, chilled-out lounge zones, free Wi-Fi and our signature Tea Tree Spa for optimum relaxation. </p>
                </div>

                <div class="bottom__button mt-4"> <p>Booked</p></div>
        </div>

    </div>
</div>
</template>

<style scoped>
@import url('https://fonts.googleapis.com/css2?family=Open+Sans&display=swap');
.main__div{
    width:100%;
    height:fit-content;
    /* border:1px solid black; */
    display:flex;
    flex-wrap: wrap;
    justify-content: center;
    align-items: center;
}

.single__trip{
    width:33%;
    height:570px;
    box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
    border-radius:10px;
    margin-top:15px;
}

.single__trip:nth-child(even){
        margin-left:10%;
}

.image__trip{
    width:100%;
    height:45%;
    border-top-left-radius:10px;
    border-top-right-radius:10px;
    overflow:hidden;
}

.image__details{
    width:100%;
    height:100%;
    object-fit: cover;
}

.title__trip{
    margin-top:2%;
    margin-left:2.5%;
    font-weight:550;
    font-family: DM Serif Display;
}

.top__details{
    width:95%;
    height:80px;
    /* outline:1px solid red; */
    margin:0 auto;
    display: flex;
    justify-content: space-between;
}

.left__top__details{
    width:48%;
    height:100%;
    /* border:1px solid black; */
    display: flex;
    align-items: flex-end;
}

.left__top__details p:nth-child(2){
    margin-left:15px;
}

.left__top__details p{
    height:fit-content;
    padding:10px;
    border:1px solid #D7D8D9;
    border-radius:10px;
    font-size:11px;
    color:#007AE9;
    font-weight:600;
    letter-spacing: 2px;
}

.right__top__details{
    width:48%;
    height:100%;
    /* border:1px solid black; */
    display: flex;
    justify-content: center;
}

.price__top__details{
    font-weight:600;
    font-size:35px;
    font-family: DM Serif Display;
}

.bottom__details{
    width:95%;
    height:90px;
    /* border:1px solid red; */
    margin:0 auto;
}

.details__p{
    color: #6E798C;
    font-size:18px;
    font-family: 'Open Sans', sans-serif;
    font-weight: 400;
}

.bottom__button{
    width:95%;
    height:60px;
    background-color: #DE3151;
    margin:0 auto;
    border-radius:15px;
    display: flex;
    justify-content: center;
    align-items: center;
}

.bottom__button p{
    margin:0;
    color:white;
    letter-spacing: 2.5px;
}

@media only screen and (max-width: 800px) {
.main__div{
    width:100%;
    height:fit-content;
    /* border:1px solid black; */
    display:flex;
    flex-direction: column;
    flex-wrap: wrap;
    justify-content: center;
    align-items: center;
}

.single__trip{
    width:80%;
    height:fit-content;
    box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
    border-radius:10px;
    margin-top:15px;
}

.bottom__details{
    width:95%;
    height:fit-content;
    /* border:1px solid red; */
    margin:0 auto;
}

.single__trip:nth-child(even) {
    margin-left: 0%;
}

}
</style>