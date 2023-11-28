import React from 'react'
import "./ProductContainer.css"
import Product from '../Product/Product'
function ProductContainer() {
    return (
        <>
            <div className="Products">
                <Product />
                <Product />
                <Product />
                <Product />
                <Product />
            </div>
        </>
    )
}

export default ProductContainer


