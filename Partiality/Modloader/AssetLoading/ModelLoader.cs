﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

using UnityEngine;

namespace Partiality.Modloader.AssetLoading {
    public class ModelLoader {

        public static ModelLoader modelLoader;

        public void Init() {
            modelLoader = this;
        }

        /// <summary>
        /// Loads a model from a .obj file, with textures and everything. 
        /// This object will be disabled by default, and you should probably cache it instead of loading from disk over and over.
        /// </summary>
        /// <param name="mesh">The mesh generated by the object</param>
        /// <param name="parent">The object to parent this model to.</param>
        /// <returns></returns>
        public GameObject LoadModelFromOBJ(string modelPath, out Mesh mesh, GameObject parent = null) {
            mesh = null;
            return null;
        }


    }
}