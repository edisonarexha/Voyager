<template>
  <div
    :style="{'height': height || '100vh', 'width': width || '100%'}"
    class="flexed-centered loader w-100"
  >

    <div class="el-loading-spinner">
      <svg viewBox="25 25 50 50" class="circular" :style="{ color: color || '#000', height: loaderSize, width: loaderSize }">
        <circle cx="50" cy="50" r="20" fill="none" class="path"></circle>
      </svg>
    </div>
    <slot />
  </div>
</template>
<script>
import { LoaderIcon, CircleIcon } from 'vue-feather-icons';

export default {
  name: 'CustomLoader',
  components: { LoaderIcon,CircleIcon },
  props: ['height', 'width', 'color', 'loaderSize'],
};
</script>
<style lang="scss" scoped>
.flexed-centered {
  display: flex;
  align-items: center;
  justify-content: center;
}

::v-deep{
  .el-loading-spinner {
    top: 50%;
    margin-top: -21px;
    width: 100%;
    text-align: center;
    position: inherit;

    .circular {
      height: 42px;
      width: 42px;
      animation: loading-rotate 2s linear infinite;

      @keyframes loading-rotate {
        100% {
          transform: rotate(1turn);
        }
      }
    }

    .path {
      animation: loading-dash 1.5s ease-in-out infinite;
      stroke-dasharray: 90,150;
      stroke-dashoffset: 0;
      stroke-width: 2;
      stroke: #409eff;
      stroke-linecap: round;

      @keyframes loading-dash {
        0% {
          stroke-dasharray: 1,200;
          stroke-dashoffset: 0;
        }
        50% {
          stroke-dasharray: 90,150;
          stroke-dashoffset: -40px;
        }
        100% {
          stroke-dasharray: 90,150;
          stroke-dashoffset: -120px;
        }
      }
    }


  }
}
</style>

