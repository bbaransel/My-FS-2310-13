import React, { useContext, useEffect } from 'react'
import { AppContext } from '../Contexts/AppContext'
import { Col, Container, Row } from 'react-bootstrap';
import User from './User';
import UserDetails from './UserDetails';

const Users = () => {
    const context = useContext(AppContext);
    console.log(context.user)
    return (
        <>
            <Container>
                <Row>
                    <Col sm={context.user.login ? 6 : 12}>
                        <Row>
                            {context.users.map(user => <User user={user} key={user.id} />)}
                        </Row>
                    </Col>
                    <Col sm={context.user.login ? 6 : 0}>
                        {context.user.login &&
                            <UserDetails login={context.user.login} />
                        }
                    </Col>
                </Row>
            </Container>

        </>
    )
}

export default Users