import { Container, Row, Col, Nav, Navbar, Image, Button, Card } from 'react-bootstrap';

import React from 'react'
import Product from './Product.js';

function Products() {
    return (
        <>
            <Container>
                <Row>
                    <Product productName={"Iphone 14"} productImageUrl={"https://picsum.photos/id/237/100/180"} />
                    <Product productName={"Vestel Buzdolabı"} productImageUrl={"https://picsum.photos/id/117/100/180"} />
                    <Product productName={"Macbook Air M2"} productImageUrl={"https://picsum.photos/id/187/100/180"} />
                    <Product productName={"Macbook Pro"} productImageUrl={"https://picsum.photos/id/119/100/180"} />
                    <Product productName={"Logitech Mouse"} productImageUrl={"https://picsum.photos/id/229/100/180"} />
                    <Product productName={"Samsung S23"} productImageUrl={"https://picsum.photos/id/188/100/180"} />
                </Row>
            </Container>
        </>
    )
}

export default Products