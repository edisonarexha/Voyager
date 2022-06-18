import mongoose from "mongoose";

const AboutSchema = new mongoose.Schema(
  {
    descriptionSecond: String,
    description: String,
    isDeleted: {
      type: Boolean,
      default: false,
    },
  },
  {
    versionKey: false,
  }
);

const About = mongoose.model("About", AboutSchema);

export default About;