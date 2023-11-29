import React from 'react'
import Product from '../Product/Product'

function ProductList({ products }) {
    return (
        <>
            {
                products.map(p => <Product key={p.id} product={p} />)
            }
        </>
    )
}


export default ProductList