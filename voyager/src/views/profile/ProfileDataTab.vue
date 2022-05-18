<template> 
<div>
    <div class="main__div mt-5">
        
        <h2 class="main__title">Profile Data:</h2>

        <b-form class="profile__tab-form">
            <b-form-group style="margin-right:5%;" class="profile__tab-form-group" label="Name">
                <b-input class="profile__tab-form-input" value="Joell"/>
            </b-form-group>
            <b-form-group class="profile__tab-form-group" label="Last name">
                <b-input class="profile__tab-form-input" value="White"/>
            </b-form-group>
            <b-form-group style="margin-right:5%;" class="profile__tab-form-group" label="Username">
                <b-input class="profile__tab-form-input" value="joellWhite2"/>
            </b-form-group>
            <b-form-group class="profile__tab-form-group" label="Email">
                <b-input class="profile__tab-form-input" value="joellwhite2@gmail.com"/>
            </b-form-group>
        </b-form>
         </div>
</div>
</template>


<style scoped>
.main__div{
    width:70%;
    height:400px;
    /* border:1px solid red; */
    margin:0 auto;
    font-family: Open Sans;
}

.main__title{
    color:#6E798C;
}

.profile__tab-form{
    width:100%;
    height:50%;
    display: flex;
    flex-wrap: wrap;
    margin: 0 auto;
    /* border:1px solid red; */
    margin-top:3%;
}

.profile__tab-form-group{
    width:47.5%;
}

.profile__tab-form-input{
    height:50px;
    color:#6E798C;
}

@media only screen and (max-width: 800px) {
.profile__tab-form{
    width:100%;
    height:50%;
    display: flex;
    flex-direction: column;
    flex-wrap: wrap;
    margin: 0 auto;
    /* border:1px solid red; */
    margin-top:3%;
}

/* .profile__tab-form-group{
    width:70%;
} */


}
</style>