﻿using ComputeSharp.Core.Interop;
using TerraFX.Interop;

namespace ComputeSharp.Shaders.Translation.Interop
{
    /// <summary>
    /// An object wrapping an <see cref="IDxcBlob"/> instance.
    /// </summary>
    internal sealed unsafe class IDxcBlobObject : NativeObject
    {
        /// <summary>
        /// The <see cref="IDxcBlob"/> instance currently in use.
        /// </summary>
        private ComPtr<IDxcBlob> dxcBlob;

        /// <summary>
        /// Creates a new <see cref="IDxcBlobObject"/> instance with the specified parameters.
        /// </summary>
        /// <param name="dxcBlob">The <see cref="IDxcBlob"/> instance to wrap.</param>
        public IDxcBlobObject(ComPtr<IDxcBlob> dxcBlob)
        {
            this.dxcBlob = dxcBlob;
        }

        /// <summary>
        /// Gets a raw pointer to the <see cref="IDxcBlob"/> instance in use.
        /// </summary>
        public IDxcBlob* DxcBlob => this.dxcBlob;

        /// <inheritdoc/>
        protected override void OnDispose()
        {
            this.dxcBlob.Dispose();
        }
    }
}
