<template>
  <div class="image" :style="{height : imageHeight , width: imageWidth}">
      <input type="file" style="display: none" ref="inputImage" @change="onFileChange($event)">
    <el-image
     @click="$refs.inputImage.click()"
      :src="url"
      :fit="fit ? fit : 'cover'"
      lazy
      style="align-self:center"
    >
    <slot name="custom"></slot>
    </el-image>
    <i v-if="(url != defaultImage) && !hideDelete" class="el-icon-delete image-delete" @click="removeImage()"></i>
    <el-progress  v-show="uploadPercentage" :text-inside="true" :stroke-width="3" :percentage="uploadPercentage"></el-progress>

    <!-- <div class="image-placeholder">
      
    </div> -->
  </div>
</template>

<script>
// import ImageUploadService from '../common/services/imageupload.service';
export default {
props: ['image','height','width', 'fit', 'remove', 'hideDelete'],
data() {
    return {
        url: '',
        imageHeight: '',
        imageWidth: '',
        defaultImage: require('@/assets/images/default.png'),
        uploadPercentage: 0
    }
},

mounted() {
    this.$nextTick(() => {
        this.url = this.image ? this.image : this.defaultImage;
        this.imageHeight = this.height ? this.height : '12rem';
        this.imageWidth = this.width ? this.width : '100%';
        })
},
methods: {
    onFileChange(){
        this.upload(this.$refs.inputImage.files[0]);
    },
    // upload(file){
    //     // this.loader = true;
    //     const fd = new FormData();
    //     fd.append('image', file, file.name);
        
    //     ImageUploadService.uploadImage(fd,event => {
    //     this.uploadPercentage = Math.round((100 * event.loaded) / event.total);
    //     })
    //     .then(response => response.data)
    //     .then(data => {
    //         this.url = data.image.image;
    //         this.$emit('onImageUpload', this.url);
    //         this.resetFileUpload();
    //     }).catch(error => {
    //         this.resetFileUpload();
    //         this.$notify(
    //            { title: 'Image Upload Error',
    //             type:'error',
    //             message: 'Error on image upload'}
    //         )
    //         throw error;
    //     });
    // },
    removeImage(){
        this.url = this.defaultImage;
        this.$emit('onImageUpload', null);
    },
    resetFileUpload(){
        this.uploadPercentage = 0;
        this.$refs.inputImage.value = '' ;
    },
},
watch: {
    image: function(newVal) {
        this.url = newVal;
    },
    remove: function(){
      if(this.remove){
        this.removeImage();
      }
    }
}
}
</script>

<style lang="scss" scoped>
.image {
  position: relative;
  padding: 5px;
  border: 1px solid #e6e6e6;
  .image-placeholder {
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    font-size: 2rem;
    color: gray;
    cursor: pointer;
  }
  .image-delete {
    position: absolute;
    display: none;
    font-size: 2rem;
    color: gray;
    cursor: pointer;
  }
  .image-delete:hover {
    color: red;
  }
  .el-image {
    cursor: pointer;
    height: 100%;
  }
}

.image:hover {
  .el-image {
    opacity: 0.2;
  }
  .image-delete {
    display: block;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
  }
}
</style>
