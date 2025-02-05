﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Emgu.CV;
using Emgu.CV.Structure;
using MarioMaker2OCR.Objects;
using System.IO;

namespace MarioMaker2OCR.Test
{
    [TestClass]
    public class TemplateTests
    {
        public static readonly string frameDir = "./Test/testdata/frames";
        public static readonly EventTemplate[] templates = new EventTemplate[] {
            new EventTemplate("./templates/480/death_big.png", "death", 0.8),
            new EventTemplate("./templates/480/death_small.png", "death", 0.8),
            new EventTemplate("./templates/480/death_partial.png", "death", 0.9),
            new EventTemplate("./templates/480/exit.png", "exit", 0.8),
            new EventTemplate("./templates/480/quit.png", "exit", 0.9),
            new EventTemplate("./templates/480/startover.png", "restart", 0.8),
        };

        [TestMethod]
        public void ReturnsEmptyAgainstStatic()
        {
            string fn = frameDir + "/480/static.png";
            var testFrame = new Image<Gray, byte>(fn);
            foreach (EventTemplate currentTemplate in templates)
            {
                var result = currentTemplate.getLocation(testFrame);
                Assert.IsTrue(result.IsEmpty, String.Format("Template {0} matched on {1} at ({2}, {3})", currentTemplate.filename, fn, result.X, result.Y));
            }
        }

        [TestMethod]
        public void ReturnsEmptyAgainstBlackScreen()
        {
            string fn = frameDir + "/480/black.png";
            var testFrame = new Image<Gray, byte>(fn);
            foreach (EventTemplate currentTemplate in templates)
            {
                var result = currentTemplate.getLocation(testFrame);
                Assert.IsTrue(result.IsEmpty, String.Format("Template {0} matched on {1} at ({2}, {3})", currentTemplate.filename, fn, result.X, result.Y));
            }
        }

        [TestMethod]
        public void ReturnsEmptyAgainstWhiteScreen()
        {
            string fn = frameDir + "/480/white.png";
            var testFrame = new Image<Gray, byte>(fn);
            foreach (EventTemplate currentTemplate in templates)
            {
                var result = currentTemplate.getLocation(testFrame);
                Assert.IsTrue(result.IsEmpty, String.Format("Template {0} matched on {1} at ({2}, {3})", currentTemplate.filename, fn, result.X, result.Y));
            }
        }

        //The Detection tests find the template in the array rather than declaring it locally so that only one location needs be updated

        [TestMethod]
        public void DetectsDeathBig()
        {
            string[] files = new string[]
            {
                "/1080/death0.png",
                "/1080/death1.png",
                "/1080/death_upsidedown.png",
            };
            foreach (var t in templates)
            {
                if (!t.filename.EndsWith("death_big.png")) continue;
                foreach (var fn in files)
                {
                    var frame = new Image<Gray, byte>(frameDir + fn).Resize(640, 480, Emgu.CV.CvEnum.Inter.Cubic);
                    var result = t.getLocation(frame);
                    Assert.IsFalse(result.IsEmpty, String.Format("Template {0} did not match {1}", t.filename, fn));
                }
            }
        }

        [TestMethod]
        public void DetectsDeathSmall()
        {
            //Finding the template in the array rather than declaring it so if threshold changes or something its only one change
            string[] files = new string[]
            {
                "/1080/death0.png",
                "/1080/death1.png",
                "/1080/death_upsidedown.png",
            };
            foreach (var t in templates)
            {
                if (!t.filename.EndsWith("death_small.png")) continue;
                foreach (var fn in files)
                {
                    var frame = new Image<Gray, byte>(frameDir + fn).Resize(640, 480, Emgu.CV.CvEnum.Inter.Cubic);
                    var result = t.getLocation(frame);
                    Assert.IsFalse(result.IsEmpty, String.Format("Template {0} did not match {1}", t.filename, fn));
                }
            }
        }

        [TestMethod]
        public void DetectsDeathPartial()
        {
            //Finding the template in the array rather than declaring it so if threshold changes or something its only one change
            string[] files = new string[]
            {
                "/1080/death0.png",
                "/1080/death1.png",
                //"/1080/death_upsidedown.png", //I'm not sure partials even happen on upside down levels, it doens't match the upside down death regardless.
            };
            foreach (var t in templates)
            {
                if (!t.filename.EndsWith("death_partial.png")) continue;
                foreach (var fn in files)
                {
                    var frame = new Image<Gray, byte>(frameDir + fn).Resize(640, 480, Emgu.CV.CvEnum.Inter.Cubic);
                    var result = t.getLocation(frame);
                    Assert.IsFalse(result.IsEmpty, String.Format("Template {0} did not match {1}", t.filename, fn));
                }
            }
        }

        [TestMethod]
        public void DetectsStartOver()
        {
            string[] files = new string[]
            {
                "/1080/startover_clearscreen.png",
                "/1080/startover_pause.png"
            };
            foreach (var t in templates)
            {
                if (!t.filename.EndsWith("startover.png")) continue;
                foreach (var fn in files)
                {
                    var frame = new Image<Gray, byte>(frameDir + fn).Resize(640, 480, Emgu.CV.CvEnum.Inter.Cubic);
                    var result = t.getLocation(frame);
                    Assert.IsFalse(result.IsEmpty, String.Format("Template {0} did not match {1}", t.filename, fn));
                }
            }
        }

        [TestMethod]
        public void DetectsExit()
        {
            string[] files = new string[]
            {
                "/1080/exit_clearscreen.png",
                "/1080/exit_pause.png"
            };
            foreach (var t in templates)
            {
                if (!t.filename.EndsWith("exit.png")) continue;
                foreach (var fn in files)
                {
                    var frame = new Image<Gray, byte>(frameDir + fn).Resize(640, 480, Emgu.CV.CvEnum.Inter.Cubic);
                    Assert.IsFalse(t.getLocation(frame).IsEmpty);
                    var result = t.getLocation(frame);
                    Assert.IsFalse(result.IsEmpty, String.Format("Template {0} did not match {1}", t.filename, fn));
                }
            }
        }

        [TestMethod]
        public void ReturnsEmptyOnGameplay()
        {
            string[] filePaths = Directory.GetFiles(frameDir + "/1080/gameplay", "*.png", SearchOption.TopDirectoryOnly);
            foreach(var fn in filePaths)
            {
                var frame = new Image<Gray, byte>(fn).Resize(640, 480, Emgu.CV.CvEnum.Inter.Cubic);
                foreach(var t in templates)
                {
                    var result = t.getLocation(frame);
                    Assert.IsTrue(result.IsEmpty, String.Format("Template {0} matched on {1} at ({2}, {3})", t.filename, fn, result.X, result.Y));
                }
            }
        }

        // TODO: Detects Quit (Endless-mode)
        // TODO: False-positive testcases
    }
}
