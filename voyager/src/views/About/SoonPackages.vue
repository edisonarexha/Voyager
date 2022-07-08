<template>
<div class="main__div">
  <div class="top__div">
    <h1>What Will Come..</h1> 
  </div>
    <div class="cont s--inactive">
  <!-- cont inner start -->
  <div class="cont__inner">
    <!-- el start -->
    <div class="el">
      <div class="el__overflow">
        <div class="el__inner">
          <div class="el__bg"></div>
          <div class="el__preview-cont">
            <h2 class="el__heading">SOMALIA</h2>
          </div>
          <div class="el__content">
            <div class="el__text">SOMALIA</div>
            <div class="el__close-btn"></div>
          </div>
        </div>
      </div>
      <div class="el__index">
        <div class="el__index-back">1</div>
        <div class="el__index-front">
          <div class="el__index-overlay" data-index="1">1</div>
        </div>
      </div>
    </div>
    <!-- el end -->
    <!-- el start -->
    <div class="el">
      <div class="el__overflow">
        <div class="el__inner">
          <div class="el__bg"></div>
          <div class="el__preview-cont">
            <h2 class="el__heading">TELLURIDE</h2>
          </div>
          <div class="el__content">
            <div class="el__text">TELLURIDE</div>
            <div class="el__close-btn"></div>
          </div>
        </div>
      </div>
      <div class="el__index">
        <div class="el__index-back">2</div>
        <div class="el__index-front">
          <div class="el__index-overlay" data-index="2">2</div>
        </div>
      </div>
    </div>
    <!-- el end -->
    <!-- el start -->
    <div class="el">
      <div class="el__overflow">
        <div class="el__inner">
          <div class="el__bg"></div>
          <div class="el__preview-cont">
            <h2 class="el__heading">BAR HARBOR</h2>
          </div>
          <div class="el__content">
            <div class="el__text">BAR HARBOR</div>
            <div class="el__close-btn"></div>
          </div>
        </div>
      </div>
      <div class="el__index">
        <div class="el__index-back">3</div>
        <div class="el__index-front">
          <div class="el__index-overlay" data-index="3">3</div>
        </div>
      </div>
    </div>
    <!-- el end -->
    <!-- el start -->
    <div class="el">
      <div class="el__overflow">
        <div class="el__inner">
          <div class="el__bg"></div>
          <div class="el__preview-cont">
            <h2 class="el__heading">GATLINBURG</h2>
          </div>
          <div class="el__content">
            <div class="el__text">GATLINBURG</div>
            <div class="el__close-btn"></div>
          </div>
        </div>
      </div>
      <div class="el__index">
        <div class="el__index-back">4</div>
        <div class="el__index-front">
          <div class="el__index-overlay" data-index="4">4</div>
        </div>
      </div>
    </div>
    <!-- el end -->
    <!-- el start -->
    <div class="el">
      <div class="el__overflow">
        <div class="el__inner">
          <div class="el__bg"></div>
          <div class="el__preview-cont">
            <h2 class="el__heading">BRECKENRIDGE</h2>
          </div>
          <div class="el__content">
            <div class="el__text">BRECKENRIDGE</div>
            <div class="el__close-btn"></div>
          </div>
        </div>
      </div>
      <div class="el__index">
        <div class="el__index-back">5</div>
        <div class="el__index-front">
          <div class="el__index-overlay" data-index="5">5</div>
        </div>
      </div>
    </div>
    <!-- el end -->
  </div>
  <!-- cont inner end -->
</div>
</div>
</template>

<script>
export default {
    mounted(){
        var $cont = document.querySelector('.cont');
var $elsArr = [].slice.call(document.querySelectorAll('.el'));
var $closeBtnsArr = [].slice.call(document.querySelectorAll('.el__close-btn'));

setTimeout(function() {
  $cont.classList.remove('s--inactive');
}, 200);

$elsArr.forEach(function($el) {
  $el.addEventListener('click', function() {
    if (this.classList.contains('s--active')) return;
    $cont.classList.add('s--el-active');
    this.classList.add('s--active');
  });
});

$closeBtnsArr.forEach(function($btn) {
  $btn.addEventListener('click', function(e) {
    e.stopPropagation();
    $cont.classList.remove('s--el-active');
    document.querySelector('.el.s--active').classList.remove('s--active');
  });
});

    }
}
</script>

<style lang="scss" scoped>
*{
  font-family: 'Open Sans';

}
.main__div{
  height:1100px;
  margin-top:50px;
  display:flex;
  flex-direction: column;
}
.top__div{
  width:80%;
  height:150px;
  margin:0 auto;
  // outline:1px solid green;
  display:flex;
  flex-direction: column;
  justify-content: center;
  align-items:center;
}
.top__div p{
  margin:0;
  margin-top:25px;
  word-spacing: 1px;
  font-size:18px;
  line-height: 30px;
}

.top__div h1{
  color:#4982c5;
  font-weight: 500;
}
$vertPad: 80px;
$sidePad: 70px;

$numOfEls: 5;
$elMrg: 1%;

$initAT: 1s;
$initDelayStep: 0.1s;
$fullInitAT: $initAT + $initDelayStep * ($numOfEls - 1);
$moveAT: 0.6s;
$expandAT: 0.7s;
$expandDelay: 0.1s;
$bgScaleAT: 0.8s;
$fadeoutAT: $moveAT + $expandAT/2;
$indexHoverAT: 0.5s;
$closeBtnAT: 0.3s;
$closeBtnLineDelay: 0.15s;
$fullExpandAT: $moveAT + $expandDelay + $expandAT;
$contentFadeinAT: 0.5s;

@mixin elHover {
  .el:hover & {
    @content;
  }
}

@mixin elActive {
  .el.s--active & {
    @content;
  }
}

@mixin contInactive {
  .cont.s--inactive & {
    @content;
  }
}

@mixin contElActive {
  .cont.s--el-active & {
    @content;
  }
}

.cont {
  position: relative;
  overflow: hidden;
  height: 100vh;
  padding: $vertPad $sidePad;

  &__inner {
    position: relative;
    height: 100%;
    
    &:hover .el__bg:after {
      opacity: 1;
    }
  }
}

.el {
  $elW: (100% - $elMrg * ($numOfEls - 1)) / $numOfEls;
  $elMrgRel: percentage($elMrg / $elW);
  
  position: absolute;
  left: 0;
  top: 0;
  width: $elW;
  height: 100%;
  background: #252525;
  transition: transform $moveAT $expandAT, width $expandAT, opacity $moveAT $expandAT, z-index 0s $moveAT + $expandAT;
  will-change: transform, width, opacity;

  &:not(.s--active) {
    cursor: pointer;
  }
  
  &__overflow {
    overflow: hidden;
    position: relative;
    height: 100%;
  }

  &__inner {
    overflow: hidden;
    position: relative;
    height: 100%;
    transition: transform $initAT;

    @include contInactive {
      transform: translate3d(0,100%,0);
    }
  }

  &__bg {
    position: relative;
    width: calc(100vw - #{$sidePad * 2});
    height: 100%;
    transition: transform $moveAT $expandAT;
    will-change: transform;

    &:before {
      content: "";
      position: absolute;
      left: 0;
      top: -5%;
      width: 100%;
      height: 110%;
      background-size: cover;
      object-fit: cover;
      background-position: center center;
      transition: transform $initAT;
      transform: translate3d(0,0,0) scale(1);

      @include contInactive {
        transform: translate3d(0,-100%,0) scale(1.2);
      }

      @include elActive {
        transition: transform $bgScaleAT;
      }
    }
    
    &:after {
      $opacityAT: 0.5s;
      
      content: "";
      z-index: 1;
      position: absolute;
      left: 0;
      top: 0;
      width: 100%;
      height: 100%;
      background: rgba(0,0,0,0.3);
      object-fit: fill;
      opacity: 0;
      transition: opacity $opacityAT;
      
      @include contElActive {
        transition: opacity $opacityAT $fullExpandAT;
        opacity: 1 !important;
      }
    }
  }
  
  &__preview-cont {
    z-index: 2;
    display: flex;
    justify-content: center;
    align-items: center;
    position: absolute;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
    transition: all 0.3s $fullInitAT - 0.2s;
    
    @include contInactive {
      opacity: 0;
      transform: translateY(10px);
    }
    
    @include contElActive {
      opacity: 0;
      transform: translateY(30px);
      transition: all 0.5s;
    }
  }
  
  &__heading {
    color: #fff;
    text-transform: uppercase;
    font-size: 18px;
  }
  
  &__content {
    z-index: -1;
    position: absolute;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
    padding: 30px;
    opacity: 0;
    pointer-events: none;
    transition: all 0.1s;
    
    @include elActive {
      z-index: 2;
      opacity: 1;
      pointer-events: auto;
      transition: all $contentFadeinAT $fullExpandAT;
    }
  }
  
  &__text {
    text-transform: uppercase;
    word-spacing: 3px;
    padding:3px;
    font-size: 20px;
    color: #fff;
  }
  
  &__close-btn {
    
    z-index: -1;
    position: absolute;
    right: 10px;
    top: 10px;
    width: 60px;
    height: 60px;
    opacity: 0;
    pointer-events: none;
    transition: all 0s $closeBtnAT + $closeBtnLineDelay;
    cursor: pointer;
    
    @include elActive {
      z-index: 5;
      opacity: 1;
      pointer-events: auto;
      transition: all 0s $fullExpandAT;
    }
    
    &:before,
    &:after {
      content: "";
      position: absolute;
      left: 0;
      top: 50%;
      width: 100%;
      height: 8px;
      margin-top: -4px;
      background: #fff;
      opacity: 0;
      transition: opacity 0s;
      
      @include elActive {
        opacity: 1;
      }
    }
    
    &:before {
      transform: rotate(45deg) translateX(100%);
      
      @include elActive {
        transition: all $closeBtnAT $fullExpandAT cubic-bezier(.72,.09,.32,1.57);
        transform: rotate(45deg) translateX(0);
      }
    }
    
    &:after {
      transform: rotate(-45deg) translateX(100%);
      
      @include elActive {
        transition: all $closeBtnAT $fullExpandAT + $closeBtnLineDelay cubic-bezier(.72,.09,.32,1.57);
        transform: rotate(-45deg) translateX(0);
      }
    }
  }
  
  &__index {
    overflow: hidden;
    position: absolute;
    left: 0;
    bottom: $vertPad * -1;
    width: 100%;
    height: 100%;
    min-height: 250px;
    text-align: center;
    font-size: 100vw / $numOfEls;
    line-height: 0.85;
    font-weight: bold;
    transition: transform $indexHoverAT, opacity $moveAT/2 $expandAT + $expandDelay + $moveAT;
    transform: translate3d(0,1vw,0);
    
    @include elHover {
      transform: translate3d(0,0,0);
    }
    
    @include contElActive {
      transition: transform $indexHoverAT, opacity $moveAT/2;
      opacity: 0;
    }
    
    &-back,
    &-front {
      position: absolute;
      left: 0;
      bottom: 0;
      width: 100%;
    }
   
    &-back {
      color: #2f3840;
      opacity: 0;
      transition: opacity $indexHoverAT/2 $indexHoverAT/2;
      
      @include elHover {
        transition: opacity $indexHoverAT/2;
        opacity: 1;
      }
    }
    
    &-overlay {
      overflow: hidden;
      position: relative;
      transform: translate3d(0,100%,0);
      transition: transform $indexHoverAT 0.1s;
      color: transparent;
      
      &:before {
        content: attr(data-index);
        position: absolute;
        left: 0;
        bottom: 0;
        width: 100%;
        height: 100%;
        color: #fff;
        transform: translate3d(0,-100%,0);
        transition: transform $indexHoverAT 0.1s;
      }
      
      @include elHover {
        transform: translate3d(0,0,0);
        
        &:before {
          transform: translate3d(0,0,0);
        }
      }
    }
  }

  @for $i from 0 to $numOfEls {
    &:nth-child(#{$i + 1}) {
      $x: (100% + $elMrgRel) * $i;
      transform: translate3d($x,0,0);
      transform-origin: $x + 50% 50%;
      
      @include contElActive {
        
        &:not(.s--active) {
          transform: scale(0.5) translate3d($x,0,0);
          opacity: 0;
          transition: transform $fadeoutAT, opacity $fadeoutAT;
        }
      }

      .el__inner {
        transition-delay: $initDelayStep * $i;
      }

      .el__bg {
        transform: translate3d($elW * $i * -1,0,0);

        &:before {
          transition-delay: 0.1s * $i;
          background-image: url('https://s3-us-west-2.amazonaws.com/s.cdpn.io/142996/onepgscr-#{$i + 3}.jpg');
          // https://lageniusinfo.com/wp-content/uploads/2018/03/team-member-6.jpg
          // background-image: url('https://lageniusinfo.com/wp-content/uploads/2018/03/team-member-6.jpg');
          // background-image: url('@/assets/teamMembers/team#{$i + 1}.jpg');

        }
      }
    }
  }
  
  &:hover {
    
    .el__bg:after {
      opacity: 0;
    }
  }

  &.s--active {
    z-index: 1;
    width: 100%;
    transform: translate3d(0,0,0);
    transition: transform $moveAT, width $expandAT $moveAT + $expandDelay, z-index 0s;

    .el__bg {
      transform: translate3d(0,0,0);
      transition: transform $moveAT;

      &:before {
        transition-delay: $moveAT;
        transform: scale(1.1);
      }
    }
  }
}

.icon-link {
  position: absolute;
  left: 5px;
  bottom: 5px;
  width: 32px;

  img {
    width: 100%;
    vertical-align: top;
  }

}


</style>