import React from 'react'
import { Card, Col } from 'react-bootstrap'
import { NavLink } from 'react-router-dom'

const User = ({ user }) => {
    return (
        <>
            <Col lg={2} md={3} sm={4} xs={6} className='mb-2'>
                <Card>
                    <Card.Img src={user.avatar_url} />
                    <Card.Body>
                        <Card.Title>
                            <h6 className='dispaly-6 fs-6 fw-bold'>{user.login}</h6>
                        </Card.Title>
                        <a href={user.html_url} className='btn btn-primary btn-sm mt-2' target='blank' >Profile</a>
                        <NavLink className='btn btn-link btn-sm' to={`/getuser/${user.login}`} >Details</NavLink>
                    </Card.Body>
                </Card>
            </Col>
        </>
    )
}

export default User