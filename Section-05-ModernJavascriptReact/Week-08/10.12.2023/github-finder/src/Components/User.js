import React, { useContext } from 'react'
import { Card, Col } from 'react-bootstrap'
import { NavLink } from 'react-router-dom'
import { AppContext } from '../Contexts/AppContext'

const User = ({ user }) => {
    const context = useContext(AppContext)
    const lgCol = context.user.login ? 4 : 2
    const mdCol = context.user.login ? 6 : 3
    const smCol = context.user.login ? 12 : 6
    return (
        <>
            <Col className='mb-2' lg={lgCol} md={mdCol} sm={smCol}>
                <Card>
                    <Card.Img src={user.avatar_url} />
                    <Card.Body>
                        <Card.Title>
                            <h6 className='dispaly-6 fs-6 fw-bold'>{user.login}</h6>
                        </Card.Title>
                        <a href={user.html_url} className='btn btn-primary btn-sm mt-2' target='blank' >Profile</a>
                        <NavLink className='btn btn-link btn-sm' onClick={() => context.getUser(user.login)} >Details</NavLink>
                    </Card.Body>
                </Card>
            </Col>
        </>
    )
}

export default User